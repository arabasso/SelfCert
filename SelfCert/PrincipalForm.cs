using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Windows.Forms;

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

            InfoKeySizeComboBox.SelectedIndex = 3;

            var certs = new List<CertSelectItem>(GetCertificates(StoreLocation.CurrentUser));

            certs.AddRange(GetCertificates(StoreLocation.LocalMachine));

            IssuerCertStoreComboBox.DataSource = certs;
            IssuerCertStoreComboBox.SelectedIndex = 0;

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

        private void EnableCertIssuer(bool flag)
        {
            IssuerCertStoreComboBox.Enabled = flag;
        }

        private void EnableFileIssuer(bool flag)
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
                    GetIssuer());

                var cert = builder.Build();

                if (SaveCertStoreRadioButton.Checked)
                {
                    var storeName = (StoreName)SaveStoreComboBox.SelectedValue;
                    var storeLocation = (StoreLocation)SaveLocationComboBox.SelectedValue;

                    var store1 = new X509Store(storeName, storeLocation);

                    store1.Open(OpenFlags.ReadWrite);

                    store1.Add(cert);

                    store1.Close();
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
                            }
                        }
                    }
                }

                MessageBox.Show(this, Properties.Resources.SaveMessage);
            }

            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message);
            }
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
    }
}
