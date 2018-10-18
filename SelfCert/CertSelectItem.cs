using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace SelfCert
{
    public class CertSelectItem
        : SelectItem<X509Certificate2>
    {
        public CertSelectItem(
            StoreLocation location,
            StoreName name,
            X509Certificate2 certificate)
            : base(certificate)
        {
            var locationText = Properties.Resources.ResourceManager.GetString("StoreLocation" + location);
            var nameText = Properties.Resources.ResourceManager.GetString("StoreName" + name);

            var match = Regex.Match(certificate.Subject, @"CN\s*=\s*(((?<cn>.+?),)|(?<cn>.+$))");

            var cn = match.Groups["cn"].Value;

            if (!string.IsNullOrEmpty(cn))
            {
                Description = $@"{locationText}\{nameText}\{cn}";
            }

            else if (!string.IsNullOrEmpty(certificate.FriendlyName))
            {
                Description = $@"{locationText}\{nameText}\{certificate.FriendlyName}";
            }

            else
            {
                Description = $@"{locationText}\{nameText}\{certificate.SubjectName}";
            }
        }
    }
}
