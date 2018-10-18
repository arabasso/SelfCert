﻿namespace SelfCert
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoSubjectLabel = new System.Windows.Forms.Label();
            this.InfoExportableCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoSubjectTextBox = new System.Windows.Forms.TextBox();
            this.InfoValidToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.InfoKeySizeLabel = new System.Windows.Forms.Label();
            this.InfoValidFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.InfoValidFromLabel = new System.Windows.Forms.Label();
            this.InfoKeySizeComboBox = new System.Windows.Forms.ComboBox();
            this.InfoValidToLabel = new System.Windows.Forms.Label();
            this.IssuerPanel = new System.Windows.Forms.Panel();
            this.IssuerGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel2.SuspendLayout();
            this.IssuerPanel.SuspendLayout();
            this.IssuerGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.SaveGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.InfoGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.InfoSubjectLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.InfoExportableCheckBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.InfoSubjectTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.InfoValidToDatePicker, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.InfoKeySizeLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.InfoValidFromDatePicker, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.InfoValidFromLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.InfoKeySizeComboBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.InfoValidToLabel, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            this.tableLayoutPanel2.SetColumnSpan(this.InfoSubjectTextBox, 4);
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
            // IssuerPanel
            // 
            resources.ApplyResources(this.IssuerPanel, "IssuerPanel");
            this.IssuerPanel.Controls.Add(this.IssuerGroupBox);
            this.IssuerPanel.Name = "IssuerPanel";
            // 
            // IssuerGroupBox
            // 
            resources.ApplyResources(this.IssuerGroupBox, "IssuerGroupBox");
            this.IssuerGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.IssuerGroupBox.Name = "IssuerGroupBox";
            this.IssuerGroupBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.IssuerPasswordTextBox, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.IssuerPasswordLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.IssuerPathLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.IssuerSelfRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.IssuerFileButton, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.IssuerCertStoreRadioButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.IssuerFileTextBox, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.IssuerCertStoreComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.IssuerFileRadioButton, 0, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
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
            this.tableLayoutPanel3.SetColumnSpan(this.IssuerCertStoreComboBox, 3);
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
            this.SaveGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.SaveGroupBox.Name = "SaveGroupBox";
            this.SaveGroupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.SaveCertStoreRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SavePasswordTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SavePasswordLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveStoreComboBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveStoreLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveFileRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveLocationLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveLocationComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            this.tableLayoutPanel1.SetColumnSpan(this.SaveButton, 2);
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
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.Load += new System.EventHandler(this.PrincipalFormLoad);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.IssuerPanel.ResumeLayout(false);
            this.IssuerPanel.PerformLayout();
            this.IssuerGroupBox.ResumeLayout(false);
            this.IssuerGroupBox.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            this.SaveGroupBox.ResumeLayout(false);
            this.SaveGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label InfoSubjectLabel;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton IssuerSelfRadioButton;
        private System.Windows.Forms.Button IssuerFileButton;
        private System.Windows.Forms.RadioButton IssuerCertStoreRadioButton;
        private System.Windows.Forms.TextBox IssuerFileTextBox;
        private System.Windows.Forms.ComboBox IssuerCertStoreComboBox;
        private System.Windows.Forms.RadioButton IssuerFileRadioButton;
        private System.Windows.Forms.Panel SavePanel;
        private System.Windows.Forms.GroupBox SaveGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}
