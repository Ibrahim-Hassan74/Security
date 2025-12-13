using Security.Controls;
using System.Drawing;

namespace Security
{
    partial class PasswordCheckerForm
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
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            lblStrength = new System.Windows.Forms.Label();
            btnCheck = new Krypton.Toolkit.KryptonButton();
            btnClear = new Krypton.Toolkit.KryptonButton();
            lblHasUpper = new System.Windows.Forms.Label();
            lblHasLower = new System.Windows.Forms.Label();
            lblHasNumber = new System.Windows.Forms.Label();
            lblHasSymbol = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 20);
            txtPassword.Margin = new System.Windows.Forms.Padding(2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(571, 136);
            txtPassword.StateCommon.Back.Color1 = Color.White;
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtPassword.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPassword.StateCommon.Border.Rounding = 15F;
            txtPassword.StateCommon.Content.Color1 = Color.Gray;
            txtPassword.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            txtPassword.TabIndex = 1;
            txtPassword.Tag = "Enter Password here";
            txtPassword.Text = "Enter Password here";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStrength.Location = new Point(77, 270);
            lblStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(0, 38);
            lblStrength.TabIndex = 2;
            // 
            // btnCheck
            // 
            btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheck.Location = new Point(77, 179);
            btnCheck.Margin = new System.Windows.Forms.Padding(2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(300, 51);
            btnCheck.StateCommon.Back.Color1 = Color.SpringGreen;
            btnCheck.StateCommon.Back.Color2 = Color.MediumSpringGreen;
            btnCheck.StateCommon.Border.Color1 = Color.Black;
            btnCheck.StateCommon.Border.Color2 = Color.Black;
            btnCheck.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnCheck.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCheck.StateCommon.Border.Rounding = 25F;
            btnCheck.StateCommon.Border.Width = 1;
            btnCheck.StateCommon.Content.LongText.Color1 = Color.White;
            btnCheck.StateCommon.Content.LongText.Color2 = Color.White;
            btnCheck.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnCheck.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnCheck.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.TabIndex = 4;
            btnCheck.Values.DropDownArrowColor = Color.Empty;
            btnCheck.Values.Text = "Check Strength";
            btnCheck.Click += btnCheck_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.Location = new Point(392, 179);
            btnClear.Margin = new System.Windows.Forms.Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(256, 51);
            btnClear.StateCommon.Back.Color1 = Color.Gainsboro;
            btnClear.StateCommon.Back.Color2 = Color.Gainsboro;
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
            btnClear.TabIndex = 7;
            btnClear.Values.DropDownArrowColor = Color.Empty;
            btnClear.Values.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // lblHasUpper
            // 
            lblHasUpper.AutoSize = true;
            lblHasUpper.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblHasUpper.Location = new Point(77, 410);
            lblHasUpper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHasUpper.Name = "lblHasUpper";
            lblHasUpper.Size = new Size(0, 31);
            lblHasUpper.TabIndex = 8;
            // 
            // lblHasLower
            // 
            lblHasLower.AutoSize = true;
            lblHasLower.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblHasLower.Location = new Point(77, 340);
            lblHasLower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHasLower.Name = "lblHasLower";
            lblHasLower.Size = new Size(0, 31);
            lblHasLower.TabIndex = 9;
            // 
            // lblHasNumber
            // 
            lblHasNumber.AutoSize = true;
            lblHasNumber.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblHasNumber.Location = new Point(77, 480);
            lblHasNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHasNumber.Name = "lblHasNumber";
            lblHasNumber.Size = new Size(0, 31);
            lblHasNumber.TabIndex = 10;
            // 
            // lblHasSymbol
            // 
            lblHasSymbol.AutoSize = true;
            lblHasSymbol.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblHasSymbol.Location = new Point(77, 550);
            lblHasSymbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHasSymbol.Name = "lblHasSymbol";
            lblHasSymbol.Size = new Size(0, 31);
            lblHasSymbol.TabIndex = 11;
            // 
            // PasswordCheckerForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new Size(717, 667);
            Controls.Add(lblHasSymbol);
            Controls.Add(lblHasNumber);
            Controls.Add(lblHasLower);
            Controls.Add(lblHasUpper);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(lblStrength);
            Controls.Add(txtPassword);
            Name = "PasswordCheckerForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = SystemColors.ButtonFace;
            StateCommon.Back.Color2 = SystemColors.ButtonFace;
            StateCommon.Border.Color1 = SystemColors.ButtonFace;
            StateCommon.Border.Color2 = SystemColors.ButtonFace;
            StateCommon.Header.Back.Color1 = SystemColors.ButtonFace;
            StateCommon.Header.Back.Color2 = SystemColors.ButtonFace;
            StateCommon.Header.Border.Color1 = SystemColors.ButtonFace;
            StateCommon.Header.Border.Color2 = SystemColors.ButtonFace;
            Text = "Password Checker";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private System.Windows.Forms.Label lblStrength;
        private Krypton.Toolkit.KryptonButton btnCheck;
        private Krypton.Toolkit.KryptonButton btnClear;
        private System.Windows.Forms.Label lblHasUpper;
        private System.Windows.Forms.Label lblHasLower;
        private System.Windows.Forms.Label lblHasNumber;
        private System.Windows.Forms.Label lblHasSymbol;
    }
}

