using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace SelfCert
{
    public class X509Certificate2Builder
    {
        public string FriendlyName { get; }
        public string Subject { get; }
        public int KeySize { get; }
        public DateTime ValidFrom { get; }
        public DateTime ValidTo { get; }
        public bool Exportable { get; }
        public X509Certificate2 Issuer { get; }
        public List<KeyPurposeID> PurposeIds { get; }

        public class X509NameEx
            : X509Name
        {
            public X509NameEx(
                string subject)
                : base(subject.Replace("S=","ST="))
            {
            }
        }

        public X509Certificate2Builder(
            string friendlyName,
            string subject,
            int keySize,
            DateTime validFrom,
            DateTime validTo,
            bool exportable,
            X509Certificate2 issuer,
            List<KeyPurposeID> purposeIds)
        {
            FriendlyName = friendlyName;
            Subject = subject;
            KeySize = keySize;
            ValidFrom = validFrom;
            ValidTo = validTo;
            Exportable = exportable;
            Issuer = issuer;
            PurposeIds = purposeIds;
        }

        public X509Certificate2 Build(
            string algorithm)
        {
            // Generating Random Numbers
            var randomGenerator = new CryptoApiRandomGenerator();
            var random = new SecureRandom(randomGenerator);

            // The Issuer Generator
            var certificateGenerator = new X509V3CertificateGenerator();

            // Serial Number
            var serialNumber = BigIntegers.CreateRandomInRange(BigInteger.One, BigInteger.ValueOf(long.MaxValue), random);
            certificateGenerator.SetSerialNumber(serialNumber);

            // Issuer and Subject Name
            certificateGenerator.SetIssuerDN(new X509NameEx(Issuer?.Subject ?? Subject));
            certificateGenerator.SetSubjectDN(new X509NameEx(Subject));

            // Authority Key Identifier
            if (Issuer != null)
            {
                var authorityKeyIdentifier = new AuthorityKeyIdentifierStructure(
                    DotNetUtilities.FromX509Certificate(Issuer));
                certificateGenerator.AddExtension(
                    X509Extensions.AuthorityKeyIdentifier.Id, false, authorityKeyIdentifier);
            }

            // Basic Constraints - issuer is allowed to be used as intermediate.
            certificateGenerator.AddExtension(
                X509Extensions.BasicConstraints.Id, true, new BasicConstraints(Exportable));

            // Extended Key Usage
            if (PurposeIds.Any())
            {
                certificateGenerator.AddExtension(
                    X509Extensions.ExtendedKeyUsage.Id, true, new ExtendedKeyUsage(PurposeIds));
            }

            // Valid For
            certificateGenerator.SetNotBefore(ValidFrom);
            certificateGenerator.SetNotAfter(ValidTo);

            // Subject Public Key
            var keyGenerationParameters = new KeyGenerationParameters(random, KeySize);
            var keyPairGenerator = new RsaKeyPairGenerator();
            keyPairGenerator.Init(keyGenerationParameters);

            var subjectKeyPair = keyPairGenerator.GenerateKeyPair();
            var issuerKeyPair = Issuer?.PrivateKey == null
                ? subjectKeyPair
                : DotNetUtilities.GetKeyPair(Issuer?.PrivateKey);

            certificateGenerator.SetPublicKey(subjectKeyPair.Public);

            var factory = new Asn1SignatureFactory(algorithm, issuerKeyPair.Private, random);

            // selfsign issuer

            var certificate = certificateGenerator.Generate(factory);

            // merge into X509Certificate2
            return Exportable
                ? new X509Certificate2(certificate.GetEncoded(), string.Empty, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet)
                {
                    PrivateKey = ConvertToRsaPrivateKey(subjectKeyPair),
                    FriendlyName = FriendlyName
                }
                : new X509Certificate2(certificate.GetEncoded())
                {
                    PrivateKey = ConvertToRsaPrivateKey(subjectKeyPair),
                    FriendlyName = FriendlyName
                };
        }

        public static AsymmetricAlgorithm ConvertToRsaPrivateKey(AsymmetricCipherKeyPair keyPair)
        {
            var keyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(keyPair.Private);
            var seq = (Asn1Sequence)Asn1Object.FromByteArray(keyInfo.ParsePrivateKey().GetDerEncoded());
            if (seq.Count != 9)
                throw new PemException("malformed sequence in RSA private key");

            var rsa = RsaPrivateKeyStructure.GetInstance(seq);
            var rsaparams = new RsaPrivateCrtKeyParameters(
                rsa.Modulus, rsa.PublicExponent, rsa.PrivateExponent, rsa.Prime1, rsa.Prime2, rsa.Exponent1,
                rsa.Exponent2, rsa.Coefficient);

            return DotNetUtilities.ToRSA(rsaparams);
        }
    }
}
