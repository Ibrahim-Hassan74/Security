using Security.Controls;

namespace Security
{
    partial class SqlInjectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlInjectionForm));
            // this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.typeTimer = new System.Windows.Forms.Timer(this.components);
            this.txtKey = new Krypton.Toolkit.KryptonTextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnGenerateKey = new Krypton.Toolkit.KryptonButton();
            this.lblStatus = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            // // this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            // // this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            // // this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            // | Krypton.Toolkit.PaletteDrawBorders.Left) 
            // | Krypton.Toolkit.PaletteDrawBorders.Right)));
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            // | Krypton.Toolkit.PaletteDrawBorders.Left) 
            // | Krypton.Toolkit.PaletteDrawBorders.Right)));
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            // | Krypton.Toolkit.PaletteDrawBorders.Left) 
            // | Krypton.Toolkit.PaletteDrawBorders.Right)));
            // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            // this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            // this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            // this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            // | Krypton.Toolkit.PaletteDrawBorders.Left) 
            // | Krypton.Toolkit.PaletteDrawBorders.Right)));
            // this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            // this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 16;
            // this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            // this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            // this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
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
            this.txtKey.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtKey.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
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
            this.btnGenerateKey.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnGenerateKey.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
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
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(363, 395);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 28);
            this.lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Values.Text = "Ready";
            // 
            // SqlInjectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 690);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SqlInjectionForm";
            // this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Injection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        // private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Timer typeTimer;
        private Krypton.Toolkit.KryptonTextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private Krypton.Toolkit.KryptonButton btnGenerateKey;
        private Krypton.Toolkit.KryptonLabel lblStatus;
    }
}

