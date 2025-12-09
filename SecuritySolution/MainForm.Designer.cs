using Security.Controls;

namespace Security
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.typeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPasswordCheckerForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSqlInjectionForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCipherAlgorithmsForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            // btnPasswordCheckerForm
            // 
            this.btnPasswordCheckerForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordCheckerForm.Location = new System.Drawing.Point(211, 271);
            this.btnPasswordCheckerForm.Name = "btnPasswordCheckerForm";
            this.btnPasswordCheckerForm.Size = new System.Drawing.Size(484, 44);
            this.btnPasswordCheckerForm.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            this.btnPasswordCheckerForm.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.btnPasswordCheckerForm.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnPasswordCheckerForm.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnPasswordCheckerForm.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnPasswordCheckerForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPasswordCheckerForm.StateCommon.Border.Rounding = 25;
            this.btnPasswordCheckerForm.StateCommon.Border.Width = 1;
            this.btnPasswordCheckerForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnPasswordCheckerForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnPasswordCheckerForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordCheckerForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnPasswordCheckerForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnPasswordCheckerForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordCheckerForm.TabIndex = 5;
            this.btnPasswordCheckerForm.Values.Text = "Password Checker";
            this.btnPasswordCheckerForm.Click += new System.EventHandler(this.btnPasswordCheckerForm_Click);
            // 
            // btnSqlInjectionForm
            // 
            this.btnSqlInjectionForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSqlInjectionForm.Location = new System.Drawing.Point(211, 341);
            this.btnSqlInjectionForm.Name = "btnSqlInjectionForm";
            this.btnSqlInjectionForm.Size = new System.Drawing.Size(484, 44);
            this.btnSqlInjectionForm.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            this.btnSqlInjectionForm.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.btnSqlInjectionForm.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnSqlInjectionForm.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnSqlInjectionForm.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSqlInjectionForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSqlInjectionForm.StateCommon.Border.Rounding = 25;
            this.btnSqlInjectionForm.StateCommon.Border.Width = 1;
            this.btnSqlInjectionForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSqlInjectionForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSqlInjectionForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlInjectionForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSqlInjectionForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSqlInjectionForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlInjectionForm.TabIndex = 6;
            this.btnSqlInjectionForm.Values.Text = "Sql Injection";
            this.btnSqlInjectionForm.Click += new System.EventHandler(this.btnSqlInjectionForm_Click);
            // 
            // btnCipherAlgorithmsForm
            // 
            this.btnCipherAlgorithmsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCipherAlgorithmsForm.Location = new System.Drawing.Point(211, 200);
            this.btnCipherAlgorithmsForm.Name = "btnCipherAlgorithmsForm";
            this.btnCipherAlgorithmsForm.Size = new System.Drawing.Size(484, 44);
            this.btnCipherAlgorithmsForm.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            this.btnCipherAlgorithmsForm.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.btnCipherAlgorithmsForm.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnCipherAlgorithmsForm.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnCipherAlgorithmsForm.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnCipherAlgorithmsForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCipherAlgorithmsForm.StateCommon.Border.Rounding = 25;
            this.btnCipherAlgorithmsForm.StateCommon.Border.Width = 1;
            this.btnCipherAlgorithmsForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnCipherAlgorithmsForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnCipherAlgorithmsForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCipherAlgorithmsForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCipherAlgorithmsForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnCipherAlgorithmsForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCipherAlgorithmsForm.TabIndex = 7;
            this.btnCipherAlgorithmsForm.Values.Text = "Cipher Algorithms";
            this.btnCipherAlgorithmsForm.Click += new System.EventHandler(this.btnCipherAlgorithmsForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 595);
            this.Controls.Add(this.btnCipherAlgorithmsForm);
            this.Controls.Add(this.btnSqlInjectionForm);
            this.Controls.Add(this.btnPasswordCheckerForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Timer typeTimer;
        //private ComponentFactory.Krypton.Toolkit.KryptonButton btnCipherAlgorithmsForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPasswordCheckerForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSqlInjectionForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCipherAlgorithmsForm;
    }
}

