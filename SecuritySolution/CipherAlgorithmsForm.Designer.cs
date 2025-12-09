using Security.Controls;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherAlgorithmsForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.typeTimer = new System.Windows.Forms.Timer(this.components);
            this.txtKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.comboBoxAlgorithms = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.txtInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblKeyHint = new System.Windows.Forms.Label();
            this.btnGenerateKey = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEncryptDecrypt = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAlgorithmInfo = new System.Windows.Forms.Label();
            this.lblKeyValidation = new System.Windows.Forms.Label();
            this.listDecryption = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.bruteForce = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAlgorithms)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(260, 188);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(408, 44);
            this.txtKey.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtKey.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKey.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKey.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtKey.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtKey.StateCommon.Border.Rounding = 15;
            this.txtKey.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtKey.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtKey.TabIndex = 1;
            this.txtKey.Tag = "Enter key here";
            this.txtKey.Text = "Enter key here";
            this.txtKey.UseSystemPasswordChar = true;
            this.txtKey.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtKey.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(17, 203);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(60, 29);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key:";
            // 
            // comboBoxAlgorithms
            // 
            this.comboBoxAlgorithms.AutoCompleteCustomSource.AddRange(new string[] {
            "Caesar Cipher",
            "Monoalphabetic Cipher",
            "Polyalphabetic (Vigenère) Cipher"});
            this.comboBoxAlgorithms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAlgorithms.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.comboBoxAlgorithms.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.comboBoxAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithms.DropDownWidth = 300;
            this.comboBoxAlgorithms.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.comboBoxAlgorithms.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.comboBoxAlgorithms.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.comboBoxAlgorithms.Location = new System.Drawing.Point(260, 104);
            this.comboBoxAlgorithms.Name = "comboBoxAlgorithms";
            this.comboBoxAlgorithms.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.comboBoxAlgorithms.Size = new System.Drawing.Size(408, 44);
            this.comboBoxAlgorithms.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxAlgorithms.StateActive.ComboBox.Border.Rounding = 25;
            this.comboBoxAlgorithms.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.comboBoxAlgorithms.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlgorithms.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(5);
            this.comboBoxAlgorithms.StateDisabled.ComboBox.Content.Color1 = System.Drawing.Color.Silver;
            this.comboBoxAlgorithms.StateDisabled.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBoxAlgorithms.StateDisabled.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBoxAlgorithms.StateDisabled.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxAlgorithms.StateDisabled.Item.Border.Rounding = 25;
            this.comboBoxAlgorithms.StateDisabled.Item.Content.Padding = new System.Windows.Forms.Padding(10);
            this.comboBoxAlgorithms.TabIndex = 3;
            this.comboBoxAlgorithms.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithms_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(449, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Simple Ciphers";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Location = new System.Drawing.Point(17, 104);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(205, 29);
            this.lblAlgorithm.TabIndex = 2;
            this.lblAlgorithm.Text = "Choose Algorithm";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(260, 329);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(408, 182);
            this.txtInput.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtInput.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInput.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInput.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInput.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtInput.StateCommon.Border.Rounding = 15;
            this.txtInput.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtInput.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtInput.TabIndex = 1;
            this.txtInput.Tag = "Enter text to encrypt";
            this.txtInput.Text = "Enter text to encrypt";
            this.txtInput.UseSystemPasswordChar = true;
            this.txtInput.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtInput.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(17, 344);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(66, 29);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Text:";
            // 
            // lblKeyHint
            // 
            this.lblKeyHint.AutoSize = true;
            this.lblKeyHint.Location = new System.Drawing.Point(255, 260);
            this.lblKeyHint.Name = "lblKeyHint";
            this.lblKeyHint.Size = new System.Drawing.Size(55, 29);
            this.lblKeyHint.TabIndex = 2;
            this.lblKeyHint.Text = "Hint";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateKey.Location = new System.Drawing.Point(726, 188);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(142, 44);
            this.btnGenerateKey.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            this.btnGenerateKey.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.btnGenerateKey.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnGenerateKey.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnGenerateKey.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnGenerateKey.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerateKey.StateCommon.Border.Rounding = 25;
            this.btnGenerateKey.StateCommon.Border.Width = 1;
            this.btnGenerateKey.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnGenerateKey.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnGenerateKey.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnGenerateKey.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnGenerateKey.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.TabIndex = 4;
            this.btnGenerateKey.Values.Text = "Generate Key";
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(260, 546);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(142, 44);
            this.btnEncryptDecrypt.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            this.btnEncryptDecrypt.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.btnEncryptDecrypt.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnEncryptDecrypt.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnEncryptDecrypt.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEncryptDecrypt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEncryptDecrypt.StateCommon.Border.Rounding = 25;
            this.btnEncryptDecrypt.StateCommon.Border.Width = 1;
            this.btnEncryptDecrypt.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnEncryptDecrypt.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnEncryptDecrypt.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptDecrypt.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnEncryptDecrypt.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnEncryptDecrypt.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptDecrypt.TabIndex = 4;
            this.btnEncryptDecrypt.Values.Text = "Encrypt";
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.btnEncryptDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(526, 546);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 44);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.Ivory;
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.Honeydew;
            this.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnClear.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnClear.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 25;
            this.btnClear.StateCommon.Border.Width = 1;
            this.btnClear.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnClear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.TabIndex = 4;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(265, 630);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 28);
            this.lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Values.Text = "Ready";
            // 
            // lblAlgorithmInfo
            // 
            this.lblAlgorithmInfo.AutoSize = true;
            this.lblAlgorithmInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithmInfo.Location = new System.Drawing.Point(722, 111);
            this.lblAlgorithmInfo.Name = "lblAlgorithmInfo";
            this.lblAlgorithmInfo.Size = new System.Drawing.Size(235, 20);
            this.lblAlgorithmInfo.TabIndex = 2;
            this.lblAlgorithmInfo.Text = "Algorithm info will appear here";
            // 
            // lblKeyValidation
            // 
            this.lblKeyValidation.AutoSize = true;
            this.lblKeyValidation.ForeColor = System.Drawing.Color.Red;
            this.lblKeyValidation.Location = new System.Drawing.Point(733, 265);
            this.lblKeyValidation.Name = "lblKeyValidation";
            this.lblKeyValidation.Size = new System.Drawing.Size(0, 29);
            this.lblKeyValidation.TabIndex = 2;
            // 
            // listDecryption
            // 
            this.listDecryption.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.listDecryption.Location = new System.Drawing.Point(783, 238);
            this.listDecryption.Name = "listDecryption";
            this.listDecryption.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.listDecryption.Size = new System.Drawing.Size(381, 320);
            this.listDecryption.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.listDecryption.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.listDecryption.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listDecryption.StateActive.Border.Rounding = 25;
            this.listDecryption.StateCheckedNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listDecryption.StateCheckedNormal.Item.Border.Rounding = 25;
            this.listDecryption.StateCheckedNormal.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedNormal.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedPressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listDecryption.StateCheckedPressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listDecryption.StateCheckedPressed.Item.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listDecryption.StateCheckedPressed.Item.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listDecryption.StateCheckedPressed.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listDecryption.StateCheckedPressed.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listDecryption.StateCheckedTracking.Item.Back.Color1 = System.Drawing.Color.Lime;
            this.listDecryption.StateCheckedTracking.Item.Back.Color2 = System.Drawing.Color.SpringGreen;
            this.listDecryption.StateCheckedTracking.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedTracking.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDecryption.StateCheckedTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.listDecryption.StateCheckedTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDecryption.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDecryption.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDecryption.TabIndex = 7;
            this.listDecryption.Visible = false;
            // 
            // bruteForce
            // 
            this.bruteForce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bruteForce.Location = new System.Drawing.Point(920, 564);
            this.bruteForce.Name = "bruteForce";
            this.bruteForce.Size = new System.Drawing.Size(142, 44);
            this.bruteForce.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.bruteForce.StateCommon.Back.Color2 = System.Drawing.Color.MintCream;
            this.bruteForce.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.bruteForce.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.bruteForce.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.bruteForce.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bruteForce.StateCommon.Border.Rounding = 25;
            this.bruteForce.StateCommon.Border.Width = 1;
            this.bruteForce.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.bruteForce.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.bruteForce.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bruteForce.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.bruteForce.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.bruteForce.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bruteForce.TabIndex = 8;
            this.bruteForce.Values.Text = "Brute Force";
            this.bruteForce.Visible = false;
            this.bruteForce.Click += new System.EventHandler(this.bruteForce_Click);
            // 
            // CipherAlgorithmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 690);
            this.Controls.Add(this.bruteForce);
            this.Controls.Add(this.listDecryption);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.comboBoxAlgorithms);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblKeyValidation);
            this.Controls.Add(this.lblKeyHint);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblAlgorithmInfo);
            this.Controls.Add(this.lblAlgorithm);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtKey);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CipherAlgorithmsForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Ciphers";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAlgorithms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Timer typeTimer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxAlgorithms;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAlgorithm;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKeyHint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGenerateKey;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEncryptDecrypt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStatus;
        private System.Windows.Forms.Label lblAlgorithmInfo;
        private System.Windows.Forms.Label lblKeyValidation;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox listDecryption;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bruteForce;
    }
}

