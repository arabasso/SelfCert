namespace SelfCert
{
    sealed partial class PrincipalForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoPurposeLabel = new System.Windows.Forms.Label();
            this.InfoSubjectLabel = new System.Windows.Forms.Label();
            this.InfoExportableCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoSubjectTextBox = new System.Windows.Forms.TextBox();
            this.InfoValidToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.InfoKeySizeLabel = new System.Windows.Forms.Label();
            this.InfoValidFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.InfoValidFromLabel = new System.Windows.Forms.Label();
            this.InfoKeySizeComboBox = new System.Windows.Forms.ComboBox();
            this.InfoValidToLabel = new System.Windows.Forms.Label();
            this.InfoPurposeServerAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoPurposeClientAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoPurposeCodeSignCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoPurposeEmailProtectionCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoAlgorithmLabel = new System.Windows.Forms.Label();
            this.InfoAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.InfoPurposeOcspSigningCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoFriendlyNameLabel = new System.Windows.Forms.Label();
            this.InfoFriendlyNameTextBox = new System.Windows.Forms.TextBox();
            this.SubjectAlternativeNameLabel = new System.Windows.Forms.Label();
            this.SubjectAlternativeNameTextBox = new System.Windows.Forms.TextBox();
            this.IssuerPanel = new System.Windows.Forms.Panel();
            this.IssuerGroupBox = new System.Windows.Forms.GroupBox();
            this.IssuerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IssuerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.IssuerPasswordLabel = new System.Windows.Forms.Label();
            this.IssuerPathLabel = new System.Windows.Forms.Label();
            this.IssuerSelfRadioButton = new System.Windows.Forms.RadioButton();
            this.IssuerFileButton = new System.Windows.Forms.Button();
            this.IssuerCertStoreRadioButton = new System.Windows.Forms.RadioButton();
            this.IssuerFileTextBox = new System.Windows.Forms.TextBox();
            this.IssuerCertStoreComboBox = new System.Windows.Forms.ComboBox();
            this.IssuerFileRadioButton = new System.Windows.Forms.RadioButton();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.SaveGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SaveCertStoreRadioButton = new System.Windows.Forms.RadioButton();
            this.SavePasswordTextBox = new System.Windows.Forms.TextBox();
            this.SavePasswordLabel = new System.Windows.Forms.Label();
            this.SaveStoreComboBox = new System.Windows.Forms.ComboBox();
            this.SaveStoreLabel = new System.Windows.Forms.Label();
            this.SaveFileRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveLocationLabel = new System.Windows.Forms.Label();
            this.SaveLocationComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.InfoTableLayoutPanel.SuspendLayout();
            this.IssuerPanel.SuspendLayout();
            this.IssuerGroupBox.SuspendLayout();
            this.IssuerTableLayoutPanel.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.SaveGroupBox.SuspendLayout();
            this.SaveTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            resources.ApplyResources(this.InfoPanel, "InfoPanel");
            this.InfoPanel.Controls.Add(this.InfoGroupBox);
            this.InfoPanel.Name = "InfoPanel";
            // 
            // InfoGroupBox
            // 
            resources.ApplyResources(this.InfoGroupBox, "InfoGroupBox");
            this.InfoGroupBox.Controls.Add(this.InfoTableLayoutPanel);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.TabStop = false;
            // 
            // InfoTableLayoutPanel
            // 
            resources.ApplyResources(this.InfoTableLayoutPanel, "InfoTableLayoutPanel");
            this.InfoTableLayoutPanel.Controls.Add(this.InfoPurposeLabel, 0, 8);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoSubjectLabel, 0, 2);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoExportableCheckBox, 4, 7);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoSubjectTextBox, 0, 3);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoValidToDatePicker, 3, 7);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoKeySizeLabel, 1, 6);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoValidFromDatePicker, 2, 7);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoValidFromLabel, 2, 6);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoKeySizeComboBox, 1, 7);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoValidToLabel, 3, 6);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoPurposeServerAuthCheckBox, 0, 9);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoPurposeClientAuthCheckBox, 1, 9);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoPurposeCodeSignCheckBox, 2, 9);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoPurposeEmailProtectionCheckBox, 3, 9);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoAlgorithmLabel, 0, 6);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoAlgorithmComboBox, 0, 7);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoPurposeOcspSigningCheckBox, 4, 9);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoFriendlyNameLabel, 0, 0);
            this.InfoTableLayoutPanel.Controls.Add(this.InfoFriendlyNameTextBox, 0, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.SubjectAlternativeNameLabel, 0, 4);
            this.InfoTableLayoutPanel.Controls.Add(this.SubjectAlternativeNameTextBox, 0, 5);
            this.InfoTableLayoutPanel.Name = "InfoTableLayoutPanel";
            // 
            // InfoPurposeLabel
            // 
            resources.ApplyResources(this.InfoPurposeLabel, "InfoPurposeLabel");
            this.InfoPurposeLabel.Name = "InfoPurposeLabel";
            // 
            // InfoSubjectLabel
            // 
            resources.ApplyResources(this.InfoSubjectLabel, "InfoSubjectLabel");
            this.InfoSubjectLabel.Name = "InfoSubjectLabel";
            // 
            // InfoExportableCheckBox
            // 
            resources.ApplyResources(this.InfoExportableCheckBox, "InfoExportableCheckBox");
            this.InfoExportableCheckBox.Name = "InfoExportableCheckBox";
            this.InfoExportableCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoSubjectTextBox
            // 
            this.InfoTableLayoutPanel.SetColumnSpan(this.InfoSubjectTextBox, 5);
            resources.ApplyResources(this.InfoSubjectTextBox, "InfoSubjectTextBox");
            this.InfoSubjectTextBox.Name = "InfoSubjectTextBox";
            // 
            // InfoValidToDatePicker
            // 
            this.InfoValidToDatePicker.Checked = false;
            resources.ApplyResources(this.InfoValidToDatePicker, "InfoValidToDatePicker");
            this.InfoValidToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InfoValidToDatePicker.Name = "InfoValidToDatePicker";
            // 
            // InfoKeySizeLabel
            // 
            resources.ApplyResources(this.InfoKeySizeLabel, "InfoKeySizeLabel");
            this.InfoKeySizeLabel.Name = "InfoKeySizeLabel";
            // 
            // InfoValidFromDatePicker
            // 
            this.InfoValidFromDatePicker.Checked = false;
            resources.ApplyResources(this.InfoValidFromDatePicker, "InfoValidFromDatePicker");
            this.InfoValidFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InfoValidFromDatePicker.Name = "InfoValidFromDatePicker";
            // 
            // InfoValidFromLabel
            // 
            resources.ApplyResources(this.InfoValidFromLabel, "InfoValidFromLabel");
            this.InfoValidFromLabel.Name = "InfoValidFromLabel";
            // 
            // InfoKeySizeComboBox
            // 
            resources.ApplyResources(this.InfoKeySizeComboBox, "InfoKeySizeComboBox");
            this.InfoKeySizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InfoKeySizeComboBox.FormattingEnabled = true;
            this.InfoKeySizeComboBox.Items.AddRange(new object[] {
            resources.GetString("InfoKeySizeComboBox.Items"),
            resources.GetString("InfoKeySizeComboBox.Items1"),
            resources.GetString("InfoKeySizeComboBox.Items2"),
            resources.GetString("InfoKeySizeComboBox.Items3"),
            resources.GetString("InfoKeySizeComboBox.Items4"),
            resources.GetString("InfoKeySizeComboBox.Items5"),
            resources.GetString("InfoKeySizeComboBox.Items6")});
            this.InfoKeySizeComboBox.Name = "InfoKeySizeComboBox";
            // 
            // InfoValidToLabel
            // 
            resources.ApplyResources(this.InfoValidToLabel, "InfoValidToLabel");
            this.InfoValidToLabel.Name = "InfoValidToLabel";
            // 
            // InfoPurposeServerAuthCheckBox
            // 
            resources.ApplyResources(this.InfoPurposeServerAuthCheckBox, "InfoPurposeServerAuthCheckBox");
            this.InfoPurposeServerAuthCheckBox.Name = "InfoPurposeServerAuthCheckBox";
            this.InfoPurposeServerAuthCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoPurposeClientAuthCheckBox
            // 
            resources.ApplyResources(this.InfoPurposeClientAuthCheckBox, "InfoPurposeClientAuthCheckBox");
            this.InfoPurposeClientAuthCheckBox.Name = "InfoPurposeClientAuthCheckBox";
            this.InfoPurposeClientAuthCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoPurposeCodeSignCheckBox
            // 
            resources.ApplyResources(this.InfoPurposeCodeSignCheckBox, "InfoPurposeCodeSignCheckBox");
            this.InfoPurposeCodeSignCheckBox.Name = "InfoPurposeCodeSignCheckBox";
            this.InfoPurposeCodeSignCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoPurposeEmailProtectionCheckBox
            // 
            resources.ApplyResources(this.InfoPurposeEmailProtectionCheckBox, "InfoPurposeEmailProtectionCheckBox");
            this.InfoPurposeEmailProtectionCheckBox.Name = "InfoPurposeEmailProtectionCheckBox";
            this.InfoPurposeEmailProtectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoAlgorithmLabel
            // 
            resources.ApplyResources(this.InfoAlgorithmLabel, "InfoAlgorithmLabel");
            this.InfoAlgorithmLabel.Name = "InfoAlgorithmLabel";
            // 
            // InfoAlgorithmComboBox
            // 
            resources.ApplyResources(this.InfoAlgorithmComboBox, "InfoAlgorithmComboBox");
            this.InfoAlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InfoAlgorithmComboBox.FormattingEnabled = true;
            this.InfoAlgorithmComboBox.Items.AddRange(new object[] {
            resources.GetString("InfoAlgorithmComboBox.Items"),
            resources.GetString("InfoAlgorithmComboBox.Items1"),
            resources.GetString("InfoAlgorithmComboBox.Items2")});
            this.InfoAlgorithmComboBox.Name = "InfoAlgorithmComboBox";
            // 
            // InfoPurposeOcspSigningCheckBox
            // 
            resources.ApplyResources(this.InfoPurposeOcspSigningCheckBox, "InfoPurposeOcspSigningCheckBox");
            this.InfoPurposeOcspSigningCheckBox.Name = "InfoPurposeOcspSigningCheckBox";
            this.InfoPurposeOcspSigningCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoFriendlyNameLabel
            // 
            resources.ApplyResources(this.InfoFriendlyNameLabel, "InfoFriendlyNameLabel");
            this.InfoFriendlyNameLabel.Name = "InfoFriendlyNameLabel";
            // 
            // InfoFriendlyNameTextBox
            // 
            this.InfoTableLayoutPanel.SetColumnSpan(this.InfoFriendlyNameTextBox, 4);
            resources.ApplyResources(this.InfoFriendlyNameTextBox, "InfoFriendlyNameTextBox");
            this.InfoFriendlyNameTextBox.Name = "InfoFriendlyNameTextBox";
            // 
            // SubjectAlternativeNameLabel
            // 
            resources.ApplyResources(this.SubjectAlternativeNameLabel, "SubjectAlternativeNameLabel");
            this.SubjectAlternativeNameLabel.Name = "SubjectAlternativeNameLabel";
            // 
            // SubjectAlternativeNameTextBox
            // 
            this.InfoTableLayoutPanel.SetColumnSpan(this.SubjectAlternativeNameTextBox, 5);
            resources.ApplyResources(this.SubjectAlternativeNameTextBox, "SubjectAlternativeNameTextBox");
            this.SubjectAlternativeNameTextBox.Name = "SubjectAlternativeNameTextBox";
            // 
            // IssuerPanel
            // 
            resources.ApplyResources(this.IssuerPanel, "IssuerPanel");
            this.IssuerPanel.Controls.Add(this.IssuerGroupBox);
            this.IssuerPanel.Name = "IssuerPanel";
            // 
            // IssuerGroupBox
            // 
            resources.ApplyResources(this.IssuerGroupBox, "IssuerGroupBox");
            this.IssuerGroupBox.Controls.Add(this.IssuerTableLayoutPanel);
            this.IssuerGroupBox.Name = "IssuerGroupBox";
            this.IssuerGroupBox.TabStop = false;
            // 
            // IssuerTableLayoutPanel
            // 
            resources.ApplyResources(this.IssuerTableLayoutPanel, "IssuerTableLayoutPanel");
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerPasswordTextBox, 2, 3);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerPasswordLabel, 1, 3);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerPathLabel, 0, 2);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerSelfRadioButton, 0, 0);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerFileButton, 3, 2);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerCertStoreRadioButton, 0, 1);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerFileTextBox, 2, 2);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerCertStoreComboBox, 1, 1);
            this.IssuerTableLayoutPanel.Controls.Add(this.IssuerFileRadioButton, 0, 2);
            this.IssuerTableLayoutPanel.Name = "IssuerTableLayoutPanel";
            // 
            // IssuerPasswordTextBox
            // 
            this.IssuerPasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IssuerPasswordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            resources.ApplyResources(this.IssuerPasswordTextBox, "IssuerPasswordTextBox");
            this.IssuerPasswordTextBox.Name = "IssuerPasswordTextBox";
            this.IssuerPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // IssuerPasswordLabel
            // 
            resources.ApplyResources(this.IssuerPasswordLabel, "IssuerPasswordLabel");
            this.IssuerPasswordLabel.Name = "IssuerPasswordLabel";
            // 
            // IssuerPathLabel
            // 
            resources.ApplyResources(this.IssuerPathLabel, "IssuerPathLabel");
            this.IssuerPathLabel.Name = "IssuerPathLabel";
            // 
            // IssuerSelfRadioButton
            // 
            resources.ApplyResources(this.IssuerSelfRadioButton, "IssuerSelfRadioButton");
            this.IssuerSelfRadioButton.Checked = true;
            this.IssuerSelfRadioButton.Name = "IssuerSelfRadioButton";
            this.IssuerSelfRadioButton.TabStop = true;
            this.IssuerSelfRadioButton.UseVisualStyleBackColor = true;
            this.IssuerSelfRadioButton.CheckedChanged += new System.EventHandler(this.IssuerSelfRadioButtonCheckedChanged);
            // 
            // IssuerFileButton
            // 
            resources.ApplyResources(this.IssuerFileButton, "IssuerFileButton");
            this.IssuerFileButton.Name = "IssuerFileButton";
            this.IssuerFileButton.UseVisualStyleBackColor = true;
            this.IssuerFileButton.Click += new System.EventHandler(this.IssuerFileButtonClick);
            // 
            // IssuerCertStoreRadioButton
            // 
            resources.ApplyResources(this.IssuerCertStoreRadioButton, "IssuerCertStoreRadioButton");
            this.IssuerCertStoreRadioButton.Name = "IssuerCertStoreRadioButton";
            this.IssuerCertStoreRadioButton.UseVisualStyleBackColor = true;
            this.IssuerCertStoreRadioButton.CheckedChanged += new System.EventHandler(this.IssuerCertRadioButtonCheckedChanged);
            // 
            // IssuerFileTextBox
            // 
            this.IssuerFileTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IssuerFileTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            resources.ApplyResources(this.IssuerFileTextBox, "IssuerFileTextBox");
            this.IssuerFileTextBox.Name = "IssuerFileTextBox";
            // 
            // IssuerCertStoreComboBox
            // 
            this.IssuerTableLayoutPanel.SetColumnSpan(this.IssuerCertStoreComboBox, 3);
            this.IssuerCertStoreComboBox.DisplayMember = "Description";
            resources.ApplyResources(this.IssuerCertStoreComboBox, "IssuerCertStoreComboBox");
            this.IssuerCertStoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IssuerCertStoreComboBox.FormattingEnabled = true;
            this.IssuerCertStoreComboBox.Name = "IssuerCertStoreComboBox";
            // 
            // IssuerFileRadioButton
            // 
            resources.ApplyResources(this.IssuerFileRadioButton, "IssuerFileRadioButton");
            this.IssuerFileRadioButton.Name = "IssuerFileRadioButton";
            this.IssuerFileRadioButton.UseVisualStyleBackColor = true;
            this.IssuerFileRadioButton.CheckedChanged += new System.EventHandler(this.IssuerFileRadioButtonCheckedChanged);
            // 
            // SavePanel
            // 
            resources.ApplyResources(this.SavePanel, "SavePanel");
            this.SavePanel.Controls.Add(this.SaveGroupBox);
            this.SavePanel.Name = "SavePanel";
            // 
            // SaveGroupBox
            // 
            resources.ApplyResources(this.SaveGroupBox, "SaveGroupBox");
            this.SaveGroupBox.Controls.Add(this.SaveTableLayoutPanel);
            this.SaveGroupBox.Name = "SaveGroupBox";
            this.SaveGroupBox.TabStop = false;
            // 
            // SaveTableLayoutPanel
            // 
            resources.ApplyResources(this.SaveTableLayoutPanel, "SaveTableLayoutPanel");
            this.SaveTableLayoutPanel.Controls.Add(this.SaveCertStoreRadioButton, 0, 0);
            this.SaveTableLayoutPanel.Controls.Add(this.SavePasswordTextBox, 2, 1);
            this.SaveTableLayoutPanel.Controls.Add(this.SavePasswordLabel, 1, 1);
            this.SaveTableLayoutPanel.Controls.Add(this.SaveStoreComboBox, 4, 0);
            this.SaveTableLayoutPanel.Controls.Add(this.SaveStoreLabel, 3, 0);
            this.SaveTableLayoutPanel.Controls.Add(this.SaveFileRadioButton, 0, 1);
            this.SaveTableLayoutPanel.Controls.Add(this.SaveLocationLabel, 1, 0);
            this.SaveTableLayoutPanel.Controls.Add(this.SaveLocationComboBox, 2, 0);
            this.SaveTableLayoutPanel.Controls.Add(this.SaveButton, 4, 2);
            this.SaveTableLayoutPanel.Name = "SaveTableLayoutPanel";
            // 
            // SaveCertStoreRadioButton
            // 
            resources.ApplyResources(this.SaveCertStoreRadioButton, "SaveCertStoreRadioButton");
            this.SaveCertStoreRadioButton.Checked = true;
            this.SaveCertStoreRadioButton.Name = "SaveCertStoreRadioButton";
            this.SaveCertStoreRadioButton.TabStop = true;
            this.SaveCertStoreRadioButton.UseVisualStyleBackColor = true;
            this.SaveCertStoreRadioButton.CheckedChanged += new System.EventHandler(this.SaveCertStoreRadioButtonCheckedChanged);
            // 
            // SavePasswordTextBox
            // 
            this.SavePasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SavePasswordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            resources.ApplyResources(this.SavePasswordTextBox, "SavePasswordTextBox");
            this.SavePasswordTextBox.Name = "SavePasswordTextBox";
            this.SavePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // SavePasswordLabel
            // 
            resources.ApplyResources(this.SavePasswordLabel, "SavePasswordLabel");
            this.SavePasswordLabel.Name = "SavePasswordLabel";
            // 
            // SaveStoreComboBox
            // 
            this.SaveStoreComboBox.DisplayMember = "Description";
            resources.ApplyResources(this.SaveStoreComboBox, "SaveStoreComboBox");
            this.SaveStoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaveStoreComboBox.FormattingEnabled = true;
            this.SaveStoreComboBox.Name = "SaveStoreComboBox";
            this.SaveStoreComboBox.ValueMember = "Value";
            // 
            // SaveStoreLabel
            // 
            resources.ApplyResources(this.SaveStoreLabel, "SaveStoreLabel");
            this.SaveStoreLabel.Name = "SaveStoreLabel";
            // 
            // SaveFileRadioButton
            // 
            resources.ApplyResources(this.SaveFileRadioButton, "SaveFileRadioButton");
            this.SaveFileRadioButton.Name = "SaveFileRadioButton";
            this.SaveFileRadioButton.UseVisualStyleBackColor = true;
            this.SaveFileRadioButton.CheckedChanged += new System.EventHandler(this.SaveFileRadioButtonCheckedChanged);
            // 
            // SaveLocationLabel
            // 
            resources.ApplyResources(this.SaveLocationLabel, "SaveLocationLabel");
            this.SaveLocationLabel.Name = "SaveLocationLabel";
            // 
            // SaveLocationComboBox
            // 
            this.SaveLocationComboBox.DisplayMember = "Description";
            resources.ApplyResources(this.SaveLocationComboBox, "SaveLocationComboBox");
            this.SaveLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaveLocationComboBox.FormattingEnabled = true;
            this.SaveLocationComboBox.Name = "SaveLocationComboBox";
            this.SaveLocationComboBox.ValueMember = "Value";
            // 
            // SaveButton
            // 
            this.SaveTableLayoutPanel.SetColumnSpan(this.SaveButton, 2);
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // PrincipalForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SavePanel);
            this.Controls.Add(this.IssuerPanel);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalFormClosing);
            this.Load += new System.EventHandler(this.PrincipalFormLoad);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.InfoTableLayoutPanel.ResumeLayout(false);
            this.InfoTableLayoutPanel.PerformLayout();
            this.IssuerPanel.ResumeLayout(false);
            this.IssuerPanel.PerformLayout();
            this.IssuerGroupBox.ResumeLayout(false);
            this.IssuerGroupBox.PerformLayout();
            this.IssuerTableLayoutPanel.ResumeLayout(false);
            this.IssuerTableLayoutPanel.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            this.SaveGroupBox.ResumeLayout(false);
            this.SaveGroupBox.PerformLayout();
            this.SaveTableLayoutPanel.ResumeLayout(false);
            this.SaveTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel InfoTableLayoutPanel;
        private System.Windows.Forms.CheckBox InfoExportableCheckBox;
        private System.Windows.Forms.TextBox InfoSubjectTextBox;
        private System.Windows.Forms.DateTimePicker InfoValidToDatePicker;
        private System.Windows.Forms.Label InfoKeySizeLabel;
        private System.Windows.Forms.DateTimePicker InfoValidFromDatePicker;
        private System.Windows.Forms.Label InfoValidFromLabel;
        private System.Windows.Forms.ComboBox InfoKeySizeComboBox;
        private System.Windows.Forms.Label InfoValidToLabel;
        private System.Windows.Forms.Panel IssuerPanel;
        private System.Windows.Forms.GroupBox IssuerGroupBox;
        private System.Windows.Forms.TableLayoutPanel IssuerTableLayoutPanel;
        private System.Windows.Forms.RadioButton IssuerSelfRadioButton;
        private System.Windows.Forms.Button IssuerFileButton;
        private System.Windows.Forms.RadioButton IssuerCertStoreRadioButton;
        private System.Windows.Forms.TextBox IssuerFileTextBox;
        private System.Windows.Forms.ComboBox IssuerCertStoreComboBox;
        private System.Windows.Forms.RadioButton IssuerFileRadioButton;
        private System.Windows.Forms.Panel SavePanel;
        private System.Windows.Forms.GroupBox SaveGroupBox;
        private System.Windows.Forms.TableLayoutPanel SaveTableLayoutPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton SaveCertStoreRadioButton;
        private System.Windows.Forms.TextBox SavePasswordTextBox;
        private System.Windows.Forms.Label SavePasswordLabel;
        private System.Windows.Forms.ComboBox SaveStoreComboBox;
        private System.Windows.Forms.Label SaveStoreLabel;
        private System.Windows.Forms.RadioButton SaveFileRadioButton;
        private System.Windows.Forms.Label SaveLocationLabel;
        private System.Windows.Forms.ComboBox SaveLocationComboBox;
        private System.Windows.Forms.Label IssuerPathLabel;
        private System.Windows.Forms.TextBox IssuerPasswordTextBox;
        private System.Windows.Forms.Label IssuerPasswordLabel;
        private System.Windows.Forms.Label InfoPurposeLabel;
        private System.Windows.Forms.CheckBox InfoPurposeServerAuthCheckBox;
        private System.Windows.Forms.CheckBox InfoPurposeClientAuthCheckBox;
        private System.Windows.Forms.CheckBox InfoPurposeCodeSignCheckBox;
        private System.Windows.Forms.CheckBox InfoPurposeEmailProtectionCheckBox;
        private System.Windows.Forms.Label InfoSubjectLabel;
        private System.Windows.Forms.Label InfoAlgorithmLabel;
        private System.Windows.Forms.ComboBox InfoAlgorithmComboBox;
        private System.Windows.Forms.CheckBox InfoPurposeOcspSigningCheckBox;
        private System.Windows.Forms.Label InfoFriendlyNameLabel;
        private System.Windows.Forms.TextBox InfoFriendlyNameTextBox;
        private System.Windows.Forms.Label SubjectAlternativeNameLabel;
        private System.Windows.Forms.TextBox SubjectAlternativeNameTextBox;
    }
}

