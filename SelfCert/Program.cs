using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SelfCert
{
    static class Program
    {
        [STAThread]
        static void Main(string [] args)
        {
            if (args.Length > 0)
            {
                var friendlyName = "";
                var subject = "CN=localhost";
                var algorithm = "SHA256WITHRSA";
                var keySize = 2048;
                var validFrom = DateTime.Now;
                var validTo = validFrom.AddYears(1);
                var exportable = true;
                var subjectAlternativeName = "";
                var purposeServer = false;
                var purposeClient = true;
                var purposeCodeSign = false;
                var purposeEmailProtection = true;
                var purposeOcspSigning = false;
                var issuerFile = "";
                var issuerPassword = "";
                var output = "";
                var password = "";

                for (var i = 0; i < args.Length; i++)
                {
                    switch (args[i].ToLower())
                    {
                        case "-friendlyname":
                            friendlyName = args[++i];
                            break;

                        case "-subject":
                            subject = args[++i];
                            break;

                        case "-keysize":
                            keySize = Convert.ToInt32(args[++i]);
                            break;

                        case "-validfrom":
                            validFrom = Convert.ToDateTime(args[++i]);
                            break;

                        case "-validto":
                            validTo = Convert.ToDateTime(args[++i]);
                            break;

                        case "-exportable":
                            exportable = Convert.ToBoolean(args[++i]);
                            break;

                        case "-subjectalternativename":
                            subjectAlternativeName = args[++i];
                            break;

                        case "-purposeserver":
                            purposeServer = Convert.ToBoolean(args[++i]);
                            break;

                        case "-purposeclient":
                            purposeClient = Convert.ToBoolean(args[++i]);
                            break;

                        case "-purposecodesign":
                            purposeCodeSign = Convert.ToBoolean(args[++i]);
                            break;

                        case "-purposeemailprotection":
                            purposeEmailProtection = Convert.ToBoolean(args[++i]);
                            break;

                        case "-purposeocspsigning":
                            purposeOcspSigning = Convert.ToBoolean(args[++i]);
                            break;

                        case "-issuerfile":
                            issuerFile = args[++i];
                            break;

                        case "-issuerpassword":
                            issuerPassword = args[++i];
                            break;

                        case "-output":
                            output = args[++i];
                            break;

                        case "-password":
                            password = args[++i];
                            break;

                        case "-algorithm":
                            algorithm = args[++i];
                            break;
                    }
                }

                var purposeIds = new List<KeyPurposeID>();

                if (purposeServer)
                {
                    purposeIds.Add(KeyPurposeID.IdKPServerAuth);
                }

                if (purposeClient)
                {
                    purposeIds.Add(KeyPurposeID.IdKPClientAuth);
                }

                if (purposeCodeSign)
                {
                    purposeIds.Add(KeyPurposeID.IdKPCodeSigning);
                }

                if (purposeEmailProtection)
                {
                    purposeIds.Add(KeyPurposeID.IdKPEmailProtection);
                }

                if (purposeOcspSigning)
                {
                    purposeIds.Add(KeyPurposeID.IdKPOcspSigning);
                }

                X509Certificate2 issuer = null;

                if (!string.IsNullOrEmpty(issuerFile))
                {
                    issuer = new X509Certificate2(issuerFile, issuerPassword, X509KeyStorageFlags.Exportable);
                }

                var builder = new X509Certificate2Builder(
                    friendlyName,
                    subject,
                    Convert.ToInt32(keySize),
                    validFrom,
                    validTo,
                    exportable,
                    issuer,
                    purposeIds);

                if (!string.IsNullOrEmpty(subjectAlternativeName))
                {
                    var names = subjectAlternativeName.Split(',')
                        .Select(s => s.Split('='))
                        .Select(s => new GeneralName(PrincipalForm.NamesDictionary[s[0].ToUpper()], s[1]))
                        .ToArray();

                    if (names.Length > 0)
                    {
                        builder.GeneralNames = new GeneralNames(names);
                    }
                }

                var cert = builder.Build(algorithm);

                using (var stream = File.Open(output, FileMode.Create))
                {
                    var bytes = cert.Export(X509ContentType.Pfx, password);

                    stream.Write(bytes, 0, bytes.Length);
                }

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalForm());
        }
    }
}
