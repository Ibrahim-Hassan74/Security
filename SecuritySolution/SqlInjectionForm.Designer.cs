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
        private void InitializeComponent() {
            txtRawSqlInput = new Krypton.Toolkit.KryptonTextBox();
            lblSqlInputLabel = new System.Windows.Forms.Label();
            btnExecuteQuery = new Krypton.Toolkit.KryptonButton();
            chkEnableInjectionMode = new Krypton.Toolkit.KryptonCheckBox();
            dgvPasswordTable = new Krypton.Toolkit.KryptonDataGridView();
            btnReloadTable = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvPasswordTable).BeginInit();
            SuspendLayout();
            // 
            // txtRawSqlInput
            // 
            txtRawSqlInput.Location = new System.Drawing.Point(49, 86);
            txtRawSqlInput.Margin = new System.Windows.Forms.Padding(2);
            txtRawSqlInput.Multiline = true;
            txtRawSqlInput.Name = "txtRawSqlInput";
            txtRawSqlInput.Size = new System.Drawing.Size(479, 131);
            txtRawSqlInput.StateCommon.Back.Color1 = System.Drawing.Color.White;
            txtRawSqlInput.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(224, 224, 224);
            txtRawSqlInput.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(224, 224, 224);
            txtRawSqlInput.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtRawSqlInput.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtRawSqlInput.StateCommon.Border.Rounding = 15F;
            txtRawSqlInput.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            txtRawSqlInput.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtRawSqlInput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            txtRawSqlInput.TabIndex = 1;
            txtRawSqlInput.Tag = "Enter SQL or Password here";
            txtRawSqlInput.Text = "Enter SQL or Password here";
            txtRawSqlInput.UseSystemPasswordChar = true;
            txtRawSqlInput.Enter += TextBox_Enter;
            txtRawSqlInput.Leave += TextBox_Leave;
            // 
            // lblSqlInputLabel
            // 
            lblSqlInputLabel.AutoSize = true;
            lblSqlInputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSqlInputLabel.Location = new System.Drawing.Point(49, 44);
            lblSqlInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSqlInputLabel.Name = "lblSqlInputLabel";
            lblSqlInputLabel.Size = new System.Drawing.Size(155, 28);
            lblSqlInputLabel.TabIndex = 2;
            lblSqlInputLabel.Text = "Raw SQL Input:";
            // 
            // btnExecuteQuery
            // 
            btnExecuteQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExecuteQuery.Location = new System.Drawing.Point(49, 256);
            btnExecuteQuery.Margin = new System.Windows.Forms.Padding(2);
            btnExecuteQuery.Name = "btnExecuteQuery";
            btnExecuteQuery.Size = new System.Drawing.Size(220, 48);
            btnExecuteQuery.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            btnExecuteQuery.StateCommon.Back.Color2 = System.Drawing.Color.MediumSpringGreen;
            btnExecuteQuery.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            btnExecuteQuery.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            btnExecuteQuery.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExecuteQuery.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExecuteQuery.StateCommon.Border.Rounding = 25F;
            btnExecuteQuery.StateCommon.Border.Width = 1;
            btnExecuteQuery.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            btnExecuteQuery.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            btnExecuteQuery.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExecuteQuery.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            btnExecuteQuery.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            btnExecuteQuery.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExecuteQuery.TabIndex = 4;
            btnExecuteQuery.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            btnExecuteQuery.Values.Text = "Execute";
            btnExecuteQuery.Click += btnExecuteQuery_Click;
            // 
            // chkEnableInjectionMode
            // 
            chkEnableInjectionMode.Location = new System.Drawing.Point(49, 222);
            chkEnableInjectionMode.Name = "chkEnableInjectionMode";
            chkEnableInjectionMode.Size = new System.Drawing.Size(240, 24);
            chkEnableInjectionMode.TabIndex = 7;
            chkEnableInjectionMode.Values.Text = "Enable Injection Mode (Unsafe)";
            // 
            // dgvPasswordTable
            // 
            dgvPasswordTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasswordTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvPasswordTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPasswordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasswordTable.Location = new System.Drawing.Point(49, 329);
            dgvPasswordTable.Name = "dgvPasswordTable";
            dgvPasswordTable.ReadOnly = true;
            dgvPasswordTable.RowHeadersWidth = 51;
            dgvPasswordTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPasswordTable.Size = new System.Drawing.Size(479, 311);
            dgvPasswordTable.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(210, 210, 210);
            dgvPasswordTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvPasswordTable.TabIndex = 9;
            // 
            // btnReloadTable
            // 
            btnReloadTable.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReloadTable.Location = new System.Drawing.Point(293, 257);
            btnReloadTable.Margin = new System.Windows.Forms.Padding(2);
            btnReloadTable.Name = "btnReloadTable";
            btnReloadTable.Size = new System.Drawing.Size(235, 47);
            btnReloadTable.StateCommon.Back.Color1 = System.Drawing.Color.MintCream;
            btnReloadTable.StateCommon.Back.Color2 = System.Drawing.Color.Honeydew;
            btnReloadTable.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            btnReloadTable.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            btnReloadTable.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnReloadTable.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnReloadTable.StateCommon.Border.Rounding = 25F;
            btnReloadTable.StateCommon.Border.Width = 1;
            btnReloadTable.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            btnReloadTable.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            btnReloadTable.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnReloadTable.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            btnReloadTable.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            btnReloadTable.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnReloadTable.TabIndex = 11;
            btnReloadTable.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            btnReloadTable.Values.Text = "Reload Password Table";
            btnReloadTable.Click += btnReloadTable_Click;
            // 
            // SqlInjectionForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(616, 686);
            Controls.Add(btnReloadTable);
            Controls.Add(dgvPasswordTable);
            Controls.Add(chkEnableInjectionMode);
            Controls.Add(btnExecuteQuery);
            Controls.Add(lblSqlInputLabel);
            Controls.Add(txtRawSqlInput);
            Name = "SqlInjectionForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Border.Color1 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Border.Color2 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Header.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Header.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Header.Border.Color1 = System.Drawing.SystemColors.ButtonFace;
            StateCommon.Header.Border.Color2 = System.Drawing.SystemColors.ButtonFace;
            Text = "Sql Injection";
            Load += SqlInjectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPasswordTable).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private Krypton.Toolkit.KryptonTextBox txtRawSqlInput;
        private System.Windows.Forms.Label lblSqlInputLabel;
        private Krypton.Toolkit.KryptonButton btnExecuteQuery;
        private Krypton.Toolkit.KryptonCheckBox chkEnableInjectionMode;
        private Krypton.Toolkit.KryptonDataGridView dgvPasswordTable;
        private Krypton.Toolkit.KryptonButton btnReloadTable;
    }
}

