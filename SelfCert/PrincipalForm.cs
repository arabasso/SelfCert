using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;

namespace SelfCert
{
    public sealed partial class PrincipalForm
        : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            Font = new Font(Font.FontFamily, Font.Size * 1f);

            LoadCerts();

            SaveLocationComboBox.DataSource = Enum.GetValues(typeof(StoreLocation))
                    .OfType<StoreLocation>()
                    .Select(s => new EnumSelectItem<StoreLocation>(s))
                    .OrderBy(ob => ob.Description)
                    .ToList();
            SaveLocationComboBox.SelectedIndex = 1;

            SaveStoreComboBox.DataSource = Enum.GetValues(typeof(StoreName))
                .OfType<StoreName>()
                .Select(s => new EnumSelectItem<StoreName>(s))
                .OrderBy(ob => ob.Description)
                .ToList();
            SaveStoreComboBox.SelectedIndex = 5;
        }

        private void LoadCerts()
        {
            var certs = new List<CertSelectItem>(GetCertificates(StoreLocation.CurrentUser));

            certs.AddRange(GetCertificates(StoreLocation.LocalMachine));

            IssuerCertStoreComboBox.DataSource = certs;
            IssuerCertStoreComboBox.SelectedIndex = 0;
        }

        private List<CertSelectItem> GetCertificates(
            StoreLocation location)
        {
            var certs = new List<CertSelectItem>();

            for (var sn = StoreName.AddressBook; sn < StoreName.TrustedPublisher; sn++)
            {
                var store = new X509Store(sn, location);

                store.Open(OpenFlags.ReadOnly);

                certs.AddRange(store.Certificates
                    .OfType<X509Certificate2>()
                    .Select(s => new CertSelectItem(location, sn, s))
                    .Where(w => !string.IsNullOrEmpty(w.Description))
                    .OrderBy(ob => ob.Description));

                store.Close();
            }

            return certs;
        }

        private void IssuerFileButtonClick(
            object sender,
            EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = Properties.Resources.IssuerFileDialogFilter;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    IssuerFileTextBox.Text = dialog.FileName;
                }
            }
        }

        private void EnableCertIssuer(
            bool flag)
        {
            IssuerCertStoreComboBox.Enabled = flag;
        }

        private void EnableFileIssuer(
            bool flag)
        {
            IssuerFileTextBox.Enabled = flag;
            IssuerFileButton.Enabled = flag;
            IssuerPathLabel.Enabled = flag;

            IssuerPasswordLabel.Enabled = flag;
            IssuerPasswordTextBox.Enabled = flag;
        }

        private void IssuerFileRadioButtonCheckedChanged(
            object sender,
            EventArgs e)
        {
            EnableCertIssuer(false);
            EnableFileIssuer(true);
        }

        private void IssuerCertRadioButtonCheckedChanged(
            object sender,
            EventArgs e)
        {
            LoadCerts();

            EnableCertIssuer(true);
            EnableFileIssuer(false);
        }

        private void IssuerSelfRadioButtonCheckedChanged(
            object sender,
            EventArgs e)
        {
            EnableCertIssuer(false);
            EnableFileIssuer(false);
        }

        private void SaveCertStoreRadioButtonCheckedChanged(
            object sender,
            EventArgs e)
        {
            EnableCertSave(true);
            EnableFileSave(false);
        }

        private void EnableCertSave(
            bool flag)
        {
            SaveLocationLabel.Enabled = flag;
            SaveLocationComboBox.Enabled = flag;

            SaveStoreLabel.Enabled = flag;
            SaveStoreComboBox.Enabled = flag;
        }

        private void EnableFileSave(
            bool flag)
        {
            SavePasswordLabel.Enabled = flag;
            SavePasswordTextBox.Enabled = flag;
        }

        private void SaveFileRadioButtonCheckedChanged(
            object sender,
            EventArgs e)
        {
            EnableCertSave(false);
            EnableFileSave(true);
        }

        private void PrincipalFormLoad(
            object sender,
            EventArgs e)
        {
            var dateNow = DateTime.Now.Date;

            InfoValidFromDatePicker.Value = dateNow.AddDays(-7);
            InfoValidToDatePicker.Value = dateNow.AddDays(365);

            Size = new Size(Size.Width, 0);

            InfoSubjectTextBox.Text = Properties.Settings.Default.InfoSubject;

            InfoAlgorithmComboBox.SelectedIndex = Properties.Settings.Default.InfoAlgorithm;
            InfoKeySizeComboBox.SelectedIndex = Properties.Settings.Default.InfoKeySize;

            InfoPurposeServerAuthCheckBox.Checked = Properties.Settings.Default.InfoPurposeServerAuth;
            InfoPurposeClientAuthCheckBox.Checked = Properties.Settings.Default.InfoPurposeClientAuth;
            InfoPurposeCodeSignCheckBox.Checked = Properties.Settings.Default.InfoPurposeCodeSign;
            InfoPurposeEmailProtectionCheckBox.Checked = Properties.Settings.Default.InfoPurposeEmailProtection;
            InfoPurposeOcspSigningCheckBox.Checked = Properties.Settings.Default.InfoPurposeOcspSigning;
        }

        private void SaveButtonClick(
            object sender,
            EventArgs e)
        {
            try
            {
                var builder = new X509Certificate2Builder(
                    InfoSubjectTextBox.Text,
                    Convert.ToInt32(InfoKeySizeComboBox.SelectedItem),
                    InfoValidFromDatePicker.Value,
                    InfoValidToDatePicker.Value,
                    InfoExportableCheckBox.Checked,
                    GetIssuer(),
                    GetPurposeIds());

                var cert = builder.Build(InfoAlgorithmComboBox.SelectedItem + "WITHRSA");

                if (SaveCertStoreRadioButton.Checked)
                {
                    var storeName = (StoreName)SaveStoreComboBox.SelectedValue;
                    var storeLocation = (StoreLocation)SaveLocationComboBox.SelectedValue;

                    var store1 = new X509Store(storeName, storeLocation);

                    store1.Open(OpenFlags.ReadWrite);

                    store1.Add(cert);

                    store1.Close();

                    MessageBox.Show(this, Properties.Resources.SaveMessage);
                }

                if (SaveFileRadioButton.Checked)
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = Properties.Resources.SaveFileDialogFilter;

                        if (dialog.ShowDialog(this) == DialogResult.OK)
                        {
                            using (var stream = File.Open(dialog.FileName, FileMode.Create))
                            {
                                var bytes = cert.Export(X509ContentType.Pfx, SavePasswordTextBox.Text);

                                stream.Write(bytes, 0, bytes.Length);

                                MessageBox.Show(this, Properties.Resources.SaveMessage);
                            }
                        }
                    }
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message);
            }
        }

        private List<KeyPurposeID> GetPurposeIds()
        {
            var purposeIds = new List<KeyPurposeID>();

            if (InfoPurposeServerAuthCheckBox.Checked)
            {
                purposeIds.Add(KeyPurposeID.IdKPServerAuth);
            }

            if (InfoPurposeClientAuthCheckBox.Checked)
            {
                purposeIds.Add(KeyPurposeID.IdKPClientAuth);
            }

            if (InfoPurposeCodeSignCheckBox.Checked)
            {
                purposeIds.Add(KeyPurposeID.IdKPCodeSigning);
            }

            if (InfoPurposeEmailProtectionCheckBox.Checked)
            {
                purposeIds.Add(KeyPurposeID.IdKPEmailProtection);
            }

            if (InfoPurposeOcspSigningCheckBox.Checked)
            {
                purposeIds.Add(KeyPurposeID.IdKPOcspSigning);
            }

            return purposeIds;
        }

        private X509Certificate2 GetIssuer()
        {
            if (IssuerCertStoreRadioButton.Checked)
            {
                return ((CertSelectItem) IssuerCertStoreComboBox.SelectedItem).Value;
            }

            return IssuerFileRadioButton.Checked
                ? new X509Certificate2(IssuerFileTextBox.Text, IssuerPasswordTextBox.Text, X509KeyStorageFlags.Exportable)
                : null;
        }

        private void PrincipalFormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            Properties.Settings.Default.InfoSubject = InfoSubjectTextBox.Text;

            Properties.Settings.Default.InfoAlgorithm = InfoAlgorithmComboBox.SelectedIndex;
            Properties.Settings.Default.InfoKeySize = InfoKeySizeComboBox.SelectedIndex;

            Properties.Settings.Default.InfoPurposeServerAuth = InfoPurposeServerAuthCheckBox.Checked;
            Properties.Settings.Default.InfoPurposeClientAuth = InfoPurposeClientAuthCheckBox.Checked;
            Properties.Settings.Default.InfoPurposeCodeSign = InfoPurposeCodeSignCheckBox.Checked;
            Properties.Settings.Default.InfoPurposeEmailProtection = InfoPurposeEmailProtectionCheckBox.Checked;
            Properties.Settings.Default.InfoPurposeOcspSigning = InfoPurposeOcspSigningCheckBox.Checked;

            Properties.Settings.Default.Save();
        }
    }
}
