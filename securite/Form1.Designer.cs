using securite.Controls;

namespace securite
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.typeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(273, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // typeTimer
            // 
            this.typeTimer.Tick += new System.EventHandler(this.typeTimer_Tick);
            // 
            // btnUserName
            // 
            this.btnUserName.Location = new System.Drawing.Point(278, 241);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(397, 32);
            this.btnUserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUserName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUserName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUserName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUserName.StateCommon.Border.Rounding = 15;
            this.btnUserName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.btnUserName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUserName.TabIndex = 1;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(278, 335);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.PasswordChar = '●';
            this.btnPassword.Size = new System.Drawing.Size(397, 32);
            this.btnPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPassword.StateCommon.Border.Rounding = 15;
            this.btnPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.btnPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(284, 189);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(284, 288);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnUserName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer typeTimer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox btnUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox btnPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}

