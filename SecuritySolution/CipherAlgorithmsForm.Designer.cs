﻿using Security.Controls;
using System.Drawing;

namespace Security
{
    partial class CipherAlgorithmsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            typeTimer = new System.Windows.Forms.Timer(components);
            txtKey = new Krypton.Toolkit.KryptonTextBox();
            lblKey = new System.Windows.Forms.Label();
            comboBoxAlgorithms = new Krypton.Toolkit.KryptonComboBox();
            lblTitle = new System.Windows.Forms.Label();
            lblAlgorithm = new System.Windows.Forms.Label();
            txtInput = new Krypton.Toolkit.KryptonTextBox();
            lblInput = new System.Windows.Forms.Label();
            lblKeyHint = new System.Windows.Forms.Label();
            btnGenerateKey = new Krypton.Toolkit.KryptonButton();
            btnEncryptDecrypt = new Krypton.Toolkit.KryptonButton();
            btnClear = new Krypton.Toolkit.KryptonButton();
            lblStatus = new Krypton.Toolkit.KryptonLabel();
            lblAlgorithmInfo = new System.Windows.Forms.Label();
            lblKeyValidation = new System.Windows.Forms.Label();
            listDecryption = new Krypton.Toolkit.KryptonListBox();
            bruteForce = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)comboBoxAlgorithms).BeginInit();
            SuspendLayout();
            // 
            // txtKey
            // 
            txtKey.Location = new Point(158, 149);
            txtKey.Margin = new System.Windows.Forms.Padding(2);
            txtKey.Multiline = true;
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(521, 59);
            txtKey.StateCommon.Back.Color1 = Color.White;
            txtKey.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtKey.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtKey.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtKey.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtKey.StateCommon.Border.Rounding = 15F;
            txtKey.StateCommon.Content.Color1 = Color.Gray;
            txtKey.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKey.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            txtKey.TabIndex = 1;
            txtKey.Tag = "Enter key here";
            txtKey.Text = "Enter key here";
            txtKey.UseSystemPasswordChar = true;
            txtKey.Enter += TextBox_Enter;
            txtKey.Leave += TextBox_Leave;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(22, 149);
            lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(36, 20);
            lblKey.TabIndex = 2;
            lblKey.Text = "Key:";
            // 
            // comboBoxAlgorithms
            // 
            comboBoxAlgorithms.AutoCompleteCustomSource.AddRange(new string[] { "Caesar Cipher", "Monoalphabetic Cipher", "Polyalphabetic (Vigenère) Cipher" });
            comboBoxAlgorithms.Cursor = System.Windows.Forms.Cursors.Hand;
            comboBoxAlgorithms.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            comboBoxAlgorithms.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
            comboBoxAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxAlgorithms.DropDownWidth = 300;
            comboBoxAlgorithms.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            comboBoxAlgorithms.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            comboBoxAlgorithms.ItemStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            comboBoxAlgorithms.Location = new Point(155, 72);
            comboBoxAlgorithms.Margin = new System.Windows.Forms.Padding(0);
            comboBoxAlgorithms.Name = "comboBoxAlgorithms";
            comboBoxAlgorithms.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            comboBoxAlgorithms.Size = new Size(518, 45);
            comboBoxAlgorithms.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxAlgorithms.StateActive.ComboBox.Border.Rounding = 25F;
            comboBoxAlgorithms.StateActive.ComboBox.Content.Color1 = Color.Black;
            comboBoxAlgorithms.StateActive.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxAlgorithms.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            comboBoxAlgorithms.StateDisabled.ComboBox.Content.Color1 = Color.Silver;
            comboBoxAlgorithms.StateDisabled.Item.Back.Color1 = Color.FromArgb(255, 192, 128);
            comboBoxAlgorithms.StateDisabled.Item.Back.Color2 = Color.FromArgb(255, 224, 192);
            comboBoxAlgorithms.StateDisabled.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxAlgorithms.StateDisabled.Item.Border.Rounding = 25F;
            comboBoxAlgorithms.StateDisabled.Item.Content.Padding = new System.Windows.Forms.Padding(10);
            comboBoxAlgorithms.TabIndex = 3;
            comboBoxAlgorithms.SelectedIndexChanged += comboBoxAlgorithms_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(509, 9);
            lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(193, 29);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Simple Ciphers";
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.AutoSize = true;
            lblAlgorithm.Location = new Point(16, 72);
            lblAlgorithm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new Size(129, 20);
            lblAlgorithm.TabIndex = 2;
            lblAlgorithm.Text = "Choose Algorithm";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(155, 315);
            txtInput.Margin = new System.Windows.Forms.Padding(2);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(521, 274);
            txtInput.StateCommon.Back.Color1 = Color.White;
            txtInput.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtInput.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtInput.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInput.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInput.StateCommon.Border.Rounding = 15F;
            txtInput.StateCommon.Content.Color1 = Color.Gray;
            txtInput.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            txtInput.TabIndex = 1;
            txtInput.Tag = "Enter text to encrypt";
            txtInput.Text = "Enter text to encrypt";
            txtInput.UseSystemPasswordChar = true;
            txtInput.Enter += TextBox_Enter;
            txtInput.Leave += TextBox_Leave;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(16, 315);
            lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(39, 20);
            lblInput.TabIndex = 2;
            lblInput.Text = "Text:";
            // 
            // lblKeyHint
            // 
            lblKeyHint.AutoSize = true;
            lblKeyHint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeyHint.Location = new Point(155, 246);
            lblKeyHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblKeyHint.Name = "lblKeyHint";
            lblKeyHint.Size = new Size(53, 28);
            lblKeyHint.TabIndex = 2;
            lblKeyHint.Text = "Hint";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerateKey.Location = new Point(752, 149);
            btnGenerateKey.Margin = new System.Windows.Forms.Padding(2);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(163, 47);
            btnGenerateKey.StateCommon.Back.Color1 = Color.SpringGreen;
            btnGenerateKey.StateCommon.Back.Color2 = Color.MediumSpringGreen;
            btnGenerateKey.StateCommon.Border.Color1 = Color.Black;
            btnGenerateKey.StateCommon.Border.Color2 = Color.Black;
            btnGenerateKey.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnGenerateKey.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGenerateKey.StateCommon.Border.Rounding = 25F;
            btnGenerateKey.StateCommon.Border.Width = 1;
            btnGenerateKey.StateCommon.Content.LongText.Color1 = Color.White;
            btnGenerateKey.StateCommon.Content.LongText.Color2 = Color.White;
            btnGenerateKey.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateKey.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnGenerateKey.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnGenerateKey.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateKey.TabIndex = 4;
            btnGenerateKey.Values.DropDownArrowColor = Color.Empty;
            btnGenerateKey.Values.Text = "Generate Key";
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // btnEncryptDecrypt
            // 
            btnEncryptDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEncryptDecrypt.Location = new Point(158, 611);
            btnEncryptDecrypt.Margin = new System.Windows.Forms.Padding(2);
            btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            btnEncryptDecrypt.Size = new Size(137, 40);
            btnEncryptDecrypt.StateCommon.Back.Color1 = Color.SpringGreen;
            btnEncryptDecrypt.StateCommon.Back.Color2 = Color.MediumSpringGreen;
            btnEncryptDecrypt.StateCommon.Border.Color1 = Color.Black;
            btnEncryptDecrypt.StateCommon.Border.Color2 = Color.Black;
            btnEncryptDecrypt.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnEncryptDecrypt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEncryptDecrypt.StateCommon.Border.Rounding = 25F;
            btnEncryptDecrypt.StateCommon.Border.Width = 1;
            btnEncryptDecrypt.StateCommon.Content.LongText.Color1 = Color.White;
            btnEncryptDecrypt.StateCommon.Content.LongText.Color2 = Color.White;
            btnEncryptDecrypt.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncryptDecrypt.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnEncryptDecrypt.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnEncryptDecrypt.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncryptDecrypt.TabIndex = 4;
            btnEncryptDecrypt.Values.DropDownArrowColor = Color.Empty;
            btnEncryptDecrypt.Values.Text = "Encrypt";
            btnEncryptDecrypt.Click += btnEncryptDecrypt_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.Location = new Point(550, 611);
            btnClear.Margin = new System.Windows.Forms.Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 40);
            btnClear.StateCommon.Back.Color1 = Color.Ivory;
            btnClear.StateCommon.Back.Color2 = Color.Honeydew;
            btnClear.StateCommon.Border.Color1 = Color.Black;
            btnClear.StateCommon.Border.Color2 = Color.Black;
            btnClear.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnClear.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnClear.StateCommon.Border.Rounding = 25F;
            btnClear.StateCommon.Border.Width = 1;
            btnClear.StateCommon.Content.LongText.Color1 = Color.White;
            btnClear.StateCommon.Content.LongText.Color2 = Color.White;
            btnClear.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnClear.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnClear.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.TabIndex = 4;
            btnClear.Values.DropDownArrowColor = Color.Empty;
            btnClear.Values.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(155, 695);
            lblStatus.Margin = new System.Windows.Forms.Padding(2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 28);
            lblStatus.StateCommon.ShortText.Color1 = Color.FromArgb(128, 255, 128);
            lblStatus.StateCommon.ShortText.Color2 = Color.FromArgb(128, 255, 128);
            lblStatus.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.TabIndex = 5;
            lblStatus.Values.Text = "Ready";
            // 
            // lblAlgorithmInfo
            // 
            lblAlgorithmInfo.AutoSize = true;
            lblAlgorithmInfo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlgorithmInfo.Location = new Point(749, 72);
            lblAlgorithmInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAlgorithmInfo.Name = "lblAlgorithmInfo";
            lblAlgorithmInfo.Size = new Size(266, 20);
            lblAlgorithmInfo.TabIndex = 2;
            lblAlgorithmInfo.Text = "Algorithm info will appear here";
            // 
            // lblKeyValidation
            // 
            lblKeyValidation.AutoSize = true;
            lblKeyValidation.ForeColor = Color.Red;
            lblKeyValidation.Location = new Point(431, 149);
            lblKeyValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblKeyValidation.Name = "lblKeyValidation";
            lblKeyValidation.Size = new Size(0, 20);
            lblKeyValidation.TabIndex = 2;
            // 
            // listDecryption
            // 
            listDecryption.ItemStyle = Krypton.Toolkit.ButtonStyle.Form;
            listDecryption.Location = new Point(752, 230);
            listDecryption.Margin = new System.Windows.Forms.Padding(2);
            listDecryption.Name = "listDecryption";
            listDecryption.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            listDecryption.Size = new Size(356, 421);
            listDecryption.StateActive.Back.Color1 = Color.White;
            listDecryption.StateActive.Back.Color2 = Color.White;
            listDecryption.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            listDecryption.StateActive.Border.Rounding = 25F;
            listDecryption.StateCheckedNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            listDecryption.StateCheckedNormal.Item.Border.Rounding = 25F;
            listDecryption.StateCheckedNormal.Item.Content.LongText.Color1 = Color.White;
            listDecryption.StateCheckedNormal.Item.Content.LongText.Color2 = Color.White;
            listDecryption.StateCheckedNormal.Item.Content.ShortText.Color1 = Color.White;
            listDecryption.StateCheckedNormal.Item.Content.ShortText.Color2 = Color.White;
            listDecryption.StateCheckedPressed.Item.Back.Color1 = Color.FromArgb(255, 128, 128);
            listDecryption.StateCheckedPressed.Item.Back.Color2 = Color.FromArgb(255, 128, 128);
            listDecryption.StateCheckedPressed.Item.Content.LongText.Color1 = Color.FromArgb(192, 255, 192);
            listDecryption.StateCheckedPressed.Item.Content.LongText.Color2 = Color.FromArgb(128, 255, 128);
            listDecryption.StateCheckedPressed.Item.Content.ShortText.Color1 = Color.FromArgb(255, 224, 192);
            listDecryption.StateCheckedPressed.Item.Content.ShortText.Color2 = Color.FromArgb(255, 224, 192);
            listDecryption.StateCheckedTracking.Item.Back.Color1 = Color.Lime;
            listDecryption.StateCheckedTracking.Item.Back.Color2 = Color.SpringGreen;
            listDecryption.StateCheckedTracking.Item.Content.LongText.Color1 = Color.White;
            listDecryption.StateCheckedTracking.Item.Content.LongText.Color2 = Color.White;
            listDecryption.StateCheckedTracking.Item.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listDecryption.StateCheckedTracking.Item.Content.ShortText.Color1 = Color.White;
            listDecryption.StateCheckedTracking.Item.Content.ShortText.Color2 = Color.White;
            listDecryption.StateCheckedTracking.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listDecryption.StateCommon.Item.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listDecryption.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listDecryption.TabIndex = 7;
            listDecryption.Visible = false;
            // 
            // bruteForce
            // 
            bruteForce.Cursor = System.Windows.Forms.Cursors.Hand;
            bruteForce.Location = new Point(862, 676);
            bruteForce.Margin = new System.Windows.Forms.Padding(2);
            bruteForce.Name = "bruteForce";
            bruteForce.Size = new Size(173, 47);
            bruteForce.StateCommon.Back.Color1 = Color.AliceBlue;
            bruteForce.StateCommon.Back.Color2 = Color.MintCream;
            bruteForce.StateCommon.Border.Color1 = Color.Black;
            bruteForce.StateCommon.Border.Color2 = Color.Black;
            bruteForce.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            bruteForce.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bruteForce.StateCommon.Border.Rounding = 25F;
            bruteForce.StateCommon.Border.Width = 1;
            bruteForce.StateCommon.Content.LongText.Color1 = Color.White;
            bruteForce.StateCommon.Content.LongText.Color2 = Color.White;
            bruteForce.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bruteForce.StateCommon.Content.ShortText.Color1 = Color.Black;
            bruteForce.StateCommon.Content.ShortText.Color2 = Color.Black;
            bruteForce.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bruteForce.TabIndex = 8;
            bruteForce.Values.DropDownArrowColor = Color.Empty;
            bruteForce.Values.Text = "Brute Force";
            bruteForce.Visible = false;
            bruteForce.Click += bruteForce_Click;
            // 
            // CipherAlgorithmsForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new Size(1132, 744);
            Controls.Add(bruteForce);
            Controls.Add(listDecryption);
            Controls.Add(lblStatus);
            Controls.Add(btnClear);
            Controls.Add(btnEncryptDecrypt);
            Controls.Add(btnGenerateKey);
            Controls.Add(comboBoxAlgorithms);
            Controls.Add(lblInput);
            Controls.Add(lblKeyValidation);
            Controls.Add(lblKeyHint);
            Controls.Add(lblKey);
            Controls.Add(lblAlgorithmInfo);
            Controls.Add(lblAlgorithm);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Controls.Add(txtKey);
            Name = "CipherAlgorithmsForm";

            InternalPanel.StateCommon.Color1 = Color.FromArgb(240, 240, 240);
            InternalPanel.StateCommon.Color2 = Color.FromArgb(240, 240, 240);

            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StateActive.Back.Color1 = SystemColors.ButtonFace;
            StateActive.Back.Color2 = SystemColors.ButtonFace;
            StateActive.Border.Color1 = SystemColors.ButtonFace;
            StateActive.Border.Color2 = SystemColors.ButtonFace;
            StateActive.Header.Back.Color1 = SystemColors.ButtonFace;
            StateActive.Header.Back.Color2 = SystemColors.ButtonFace;
            StateActive.Header.Border.Color1 = SystemColors.ButtonFace;
            StateActive.Header.Border.Color2 = SystemColors.ButtonFace;
            Text = "Simple Ciphers";
            Load += CipherAlgorithmsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)comboBoxAlgorithms).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        // private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Timer typeTimer;
        private Krypton.Toolkit.KryptonTextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private Krypton.Toolkit.KryptonComboBox comboBoxAlgorithms;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAlgorithm;
        private Krypton.Toolkit.KryptonTextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKeyHint;
        private Krypton.Toolkit.KryptonButton btnGenerateKey;
        private Krypton.Toolkit.KryptonButton btnEncryptDecrypt;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonLabel lblStatus;
        private System.Windows.Forms.Label lblAlgorithmInfo;
        private System.Windows.Forms.Label lblKeyValidation;
        private Krypton.Toolkit.KryptonListBox listDecryption;
        private Krypton.Toolkit.KryptonButton bruteForce;
    }
}