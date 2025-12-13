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
            components = new System.ComponentModel.Container();
            typeTimer = new System.Windows.Forms.Timer(components);
            txtQuery = new Krypton.Toolkit.KryptonTextBox();
            lblText = new System.Windows.Forms.Label();
            btnInject = new Krypton.Toolkit.KryptonButton();
            chkInject = new Krypton.Toolkit.KryptonCheckBox();
            dgvPasswords = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPasswords).BeginInit();
            SuspendLayout();
            // 
            // txtQuery
            // 
            txtQuery.Location = new System.Drawing.Point(180, 34);
            txtQuery.Margin = new System.Windows.Forms.Padding(2);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new System.Drawing.Size(287, 84);
            txtQuery.StateCommon.Back.Color1 = System.Drawing.Color.White;
            txtQuery.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(224, 224, 224);
            txtQuery.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(224, 224, 224);
            txtQuery.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuery.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuery.StateCommon.Border.Rounding = 15F;
            txtQuery.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            txtQuery.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtQuery.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            txtQuery.TabIndex = 1;
            txtQuery.Tag = "Enter key here";
            txtQuery.Text = "Enter key here";
            txtQuery.UseSystemPasswordChar = true;
            txtQuery.Enter += TextBox_Enter;
            txtQuery.Leave += TextBox_Leave;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new System.Drawing.Point(41, 34);
            lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblText.Name = "lblText";
            lblText.Size = new System.Drawing.Size(45, 20);
            lblText.TabIndex = 2;
            lblText.Text = "TEXT:";
            // 
            // btnInject
            // 
            btnInject.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInject.Location = new System.Drawing.Point(516, 53);
            btnInject.Margin = new System.Windows.Forms.Padding(2);
            btnInject.Name = "btnInject";
            btnInject.Size = new System.Drawing.Size(235, 47);
            btnInject.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            btnInject.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            btnInject.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            btnInject.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            btnInject.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnInject.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInject.StateCommon.Border.Rounding = 25F;
            btnInject.StateCommon.Border.Width = 1;
            btnInject.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            btnInject.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            btnInject.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInject.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            btnInject.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            btnInject.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInject.TabIndex = 4;
            btnInject.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            btnInject.Values.Text = "Try Inject";
            btnInject.Click += btnInject_Click;
            // 
            // chkInject
            // 
            chkInject.Location = new System.Drawing.Point(516, 115);
            chkInject.Name = "chkInject";
            chkInject.Size = new System.Drawing.Size(65, 24);
            chkInject.TabIndex = 7;
            chkInject.Values.Text = "Inject";
            // 
            // dgvPasswords
            // 
            dgvPasswords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasswords.Location = new System.Drawing.Point(70, 190);
            dgvPasswords.Name = "dgvPasswords";
            dgvPasswords.RowHeadersWidth = 51;
            dgvPasswords.Size = new System.Drawing.Size(681, 330);
            dgvPasswords.TabIndex = 9;
            // 
            // SqlInjectionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(867, 584);
            Controls.Add(dgvPasswords);
            Controls.Add(chkInject);
            Controls.Add(btnInject);
            Controls.Add(lblText);
            Controls.Add(txtQuery);
            Name = "SqlInjectionForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sql Injection";
            ((System.ComponentModel.ISupportInitialize)dgvPasswords).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        // private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Timer typeTimer;
        private Krypton.Toolkit.KryptonTextBox txtQuery;
        private System.Windows.Forms.Label lblText;
        private Krypton.Toolkit.KryptonButton btnInject;
        private Krypton.Toolkit.KryptonCheckBox chkInject;
        private Krypton.Toolkit.KryptonDataGridView dgvPasswords;
    }
}

