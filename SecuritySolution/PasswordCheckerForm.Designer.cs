using Security.Controls;

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
            components = new System.ComponentModel.Container();
            typeTimer = new System.Windows.Forms.Timer(components);
            txtKey = new Krypton.Toolkit.KryptonTextBox();
            lblKey = new System.Windows.Forms.Label();
            btnGenerateKey = new Krypton.Toolkit.KryptonButton();
            lblStatus = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // txtKey
            // 
            txtKey.Location = new System.Drawing.Point(172, 11);
            txtKey.Margin = new System.Windows.Forms.Padding(2);
            txtKey.Multiline = true;
            txtKey.Name = "txtKey";
            txtKey.Size = new System.Drawing.Size(472, 121);
            txtKey.StateCommon.Back.Color1 = System.Drawing.Color.White;
            txtKey.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(224, 224, 224);
            txtKey.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(224, 224, 224);
            txtKey.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtKey.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtKey.StateCommon.Border.Rounding = 15F;
            txtKey.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            txtKey.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtKey.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            txtKey.TabIndex = 1;
            txtKey.Tag = "Enter key here";
            txtKey.Text = "Enter key here";
            txtKey.UseSystemPasswordChar = true;
            txtKey.TextChanged += txtKey_TextChanged;
            txtKey.Enter += TextBox_Enter;
            txtKey.Leave += TextBox_Leave;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new System.Drawing.Point(12, 38);
            lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblKey.Name = "lblKey";
            lblKey.Size = new System.Drawing.Size(36, 20);
            lblKey.TabIndex = 2;
            lblKey.Text = "Key:";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerateKey.Location = new System.Drawing.Point(732, 60);
            btnGenerateKey.Margin = new System.Windows.Forms.Padding(2);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new System.Drawing.Size(266, 51);
            btnGenerateKey.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            btnGenerateKey.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            btnGenerateKey.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            btnGenerateKey.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            btnGenerateKey.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnGenerateKey.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGenerateKey.StateCommon.Border.Rounding = 25F;
            btnGenerateKey.StateCommon.Border.Width = 1;
            btnGenerateKey.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            btnGenerateKey.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            btnGenerateKey.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGenerateKey.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            btnGenerateKey.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            btnGenerateKey.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGenerateKey.TabIndex = 4;
            btnGenerateKey.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            btnGenerateKey.Values.Text = "Generate Key";
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new System.Drawing.Point(732, 141);
            lblStatus.Margin = new System.Windows.Forms.Padding(2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(75, 28);
            lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(128, 255, 128);
            lblStatus.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(128, 255, 128);
            lblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStatus.TabIndex = 5;
            lblStatus.Values.Text = "Ready";
            // 
            // PasswordCheckerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1132, 744);
            Controls.Add(lblStatus);
            Controls.Add(btnGenerateKey);
            Controls.Add(lblKey);
            Controls.Add(txtKey);
            Name = "PasswordCheckerForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Password Checker";
            ResumeLayout(false);
            PerformLayout();

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

