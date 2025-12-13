using Security.Controls;
using System.Drawing;

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
            btnPasswordCheckerForm = new Krypton.Toolkit.KryptonButton();
            btnSqlInjectionForm = new Krypton.Toolkit.KryptonButton();
            btnCipherAlgorithmsForm = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // btnPasswordCheckerForm
            // 
            btnPasswordCheckerForm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPasswordCheckerForm.Location = new Point(202, 258);
            btnPasswordCheckerForm.Margin = new System.Windows.Forms.Padding(2);
            btnPasswordCheckerForm.Name = "btnPasswordCheckerForm";
            btnPasswordCheckerForm.Size = new Size(439, 49);
            btnPasswordCheckerForm.StateCommon.Back.Color1 = Color.SpringGreen;
            btnPasswordCheckerForm.StateCommon.Back.Color2 = Color.MediumSpringGreen;
            btnPasswordCheckerForm.StateCommon.Border.Color1 = Color.Black;
            btnPasswordCheckerForm.StateCommon.Border.Color2 = Color.Black;
            btnPasswordCheckerForm.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPasswordCheckerForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPasswordCheckerForm.StateCommon.Border.Rounding = 25F;
            btnPasswordCheckerForm.StateCommon.Border.Width = 1;
            btnPasswordCheckerForm.StateCommon.Content.LongText.Color1 = Color.White;
            btnPasswordCheckerForm.StateCommon.Content.LongText.Color2 = Color.White;
            btnPasswordCheckerForm.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPasswordCheckerForm.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnPasswordCheckerForm.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnPasswordCheckerForm.StateCommon.Content.ShortText.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPasswordCheckerForm.TabIndex = 5;
            btnPasswordCheckerForm.Values.DropDownArrowColor = Color.Empty;
            btnPasswordCheckerForm.Values.Text = "Password Checker";
            btnPasswordCheckerForm.Click += btnPasswordCheckerForm_Click;
            // 
            // btnSqlInjectionForm
            // 
            btnSqlInjectionForm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSqlInjectionForm.Location = new Point(202, 339);
            btnSqlInjectionForm.Margin = new System.Windows.Forms.Padding(2);
            btnSqlInjectionForm.Name = "btnSqlInjectionForm";
            btnSqlInjectionForm.Size = new Size(439, 56);
            btnSqlInjectionForm.StateCommon.Back.Color1 = Color.SpringGreen;
            btnSqlInjectionForm.StateCommon.Back.Color2 = Color.MediumSpringGreen;
            btnSqlInjectionForm.StateCommon.Border.Color1 = Color.Black;
            btnSqlInjectionForm.StateCommon.Border.Color2 = Color.Black;
            btnSqlInjectionForm.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSqlInjectionForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSqlInjectionForm.StateCommon.Border.Rounding = 25F;
            btnSqlInjectionForm.StateCommon.Border.Width = 1;
            btnSqlInjectionForm.StateCommon.Content.LongText.Color1 = Color.White;
            btnSqlInjectionForm.StateCommon.Content.LongText.Color2 = Color.White;
            btnSqlInjectionForm.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSqlInjectionForm.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnSqlInjectionForm.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnSqlInjectionForm.StateCommon.Content.ShortText.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSqlInjectionForm.TabIndex = 6;
            btnSqlInjectionForm.Values.DropDownArrowColor = Color.Empty;
            btnSqlInjectionForm.Values.Text = "Sql Injection";
            btnSqlInjectionForm.Click += btnSqlInjectionForm_Click;
            // 
            // btnCipherAlgorithmsForm
            // 
            btnCipherAlgorithmsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCipherAlgorithmsForm.Location = new Point(202, 174);
            btnCipherAlgorithmsForm.Margin = new System.Windows.Forms.Padding(2);
            btnCipherAlgorithmsForm.Name = "btnCipherAlgorithmsForm";
            btnCipherAlgorithmsForm.Size = new Size(439, 51);
            btnCipherAlgorithmsForm.StateCommon.Back.Color1 = Color.SpringGreen;
            btnCipherAlgorithmsForm.StateCommon.Back.Color2 = Color.MediumSpringGreen;
            btnCipherAlgorithmsForm.StateCommon.Border.Color1 = Color.Black;
            btnCipherAlgorithmsForm.StateCommon.Border.Color2 = Color.Black;
            btnCipherAlgorithmsForm.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnCipherAlgorithmsForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCipherAlgorithmsForm.StateCommon.Border.Rounding = 25F;
            btnCipherAlgorithmsForm.StateCommon.Border.Width = 1;
            btnCipherAlgorithmsForm.StateCommon.Content.LongText.Color1 = Color.White;
            btnCipherAlgorithmsForm.StateCommon.Content.LongText.Color2 = Color.White;
            btnCipherAlgorithmsForm.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCipherAlgorithmsForm.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnCipherAlgorithmsForm.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnCipherAlgorithmsForm.StateCommon.Content.ShortText.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCipherAlgorithmsForm.StatePressed.Back.Color1 = Color.SpringGreen;
            btnCipherAlgorithmsForm.StatePressed.Back.Color2 = Color.MediumSpringGreen;
            btnCipherAlgorithmsForm.StatePressed.Border.Color1 = Color.Black;
            btnCipherAlgorithmsForm.StatePressed.Border.Color2 = Color.Black;
            btnCipherAlgorithmsForm.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCipherAlgorithmsForm.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCipherAlgorithmsForm.TabIndex = 7;
            btnCipherAlgorithmsForm.Values.DropDownArrowColor = Color.Empty;
            btnCipherAlgorithmsForm.Values.Text = "Cipher Algorithms";
            btnCipherAlgorithmsForm.Click += btnCipherAlgorithmsForm_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new Size(872, 598);
            Controls.Add(btnCipherAlgorithmsForm);
            Controls.Add(btnSqlInjectionForm);
            Controls.Add(btnPasswordCheckerForm);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StateActive.Back.Color1 = SystemColors.ButtonFace;
            StateActive.Back.Color2 = SystemColors.ButtonFace;
            StateActive.Border.Color1 = SystemColors.ButtonFace;
            StateActive.Border.Color2 = SystemColors.ButtonFace;
            StateActive.Header.Back.Color1 = SystemColors.ButtonFace;
            StateActive.Header.Back.Color2 = SystemColors.ButtonFace;
            Text = "Main Form";
            ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        //private Krypton.Toolkit.KryptonButton btnCipherAlgorithmsForm;
        private Krypton.Toolkit.KryptonButton btnPasswordCheckerForm;
        private Krypton.Toolkit.KryptonButton btnSqlInjectionForm;
        private Krypton.Toolkit.KryptonButton btnCipherAlgorithmsForm;
    }
}

