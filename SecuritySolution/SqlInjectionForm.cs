using Krypton.Toolkit;
using Microsoft.Data.SqlClient; // for ADO fallback
using Microsoft.EntityFrameworkCore;
using Security.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Security
{
    public partial class SqlInjectionForm : KryptonForm {
        private readonly ApplicationDbContext _db;

        public SqlInjectionForm(ApplicationDbContext db) {
            _db = db;
            InitializeComponent();

            InternalPanel.StateCommon.Color1 = Color.FromArgb(240, 240, 240);
            InternalPanel.StateCommon.Color2 = Color.FromArgb(240, 240, 240);

            lblSqlInputLabel.Text = "Raw SQL Input:";
            btnExecuteQuery.Text = "Execute";
            chkEnableInjectionMode.Text = "Enable Injection Mode (Unsafe)";
            txtRawSqlInput.Tag = "Enter SQL or Password here";
            SetPlaceholder(txtRawSqlInput, txtRawSqlInput.Tag?.ToString() ?? "");

            btnReloadTable.Text = "Reload Password Table";

            RefreshPasswordsGrid();
        }

        private void TextBox_Enter(object sender, EventArgs e) {
            var txt = sender as KryptonTextBox;
            if (txt == null) return;
            string placeholder = txt.Tag?.ToString() ?? "";
            RemovePlaceholder(txt, placeholder);
        }

        private void TextBox_Leave(object sender, EventArgs e) {
            var txt = sender as KryptonTextBox;
            if (txt == null) return;
            string placeholder = txt.Tag?.ToString() ?? "";
            SetPlaceholder(txt, placeholder);
        }

        private void SetPlaceholder(KryptonTextBox txt, string placeholder) {
            if (string.IsNullOrWhiteSpace(txt.Text)) {
                txt.Text = placeholder;
                txt.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void RemovePlaceholder(KryptonTextBox txt, string placeholder) {
            if (txt.Text == placeholder) {
                txt.Text = "";
                txt.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e) {
            string placeholder = txtRawSqlInput.Tag?.ToString() ?? "";
            string input = txtRawSqlInput.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(input) || input == placeholder) {
                MessageBox.Show("Please enter a query or password in the text box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkEnableInjectionMode.Checked) {
                InsertPassword_Vulnerable(input);
            }
            else {
                InsertPassword_Secure(input);
            }
            btnReloadTable.PerformClick();
        }

        private void InsertPassword_Secure(string passwordValue) {
            try {
                var pw = new Password { Password1 = passwordValue };
                _db.Passwords.Add(pw);
                _db.SaveChanges();

                MessageBox.Show(
                    "Inserted safely (parameterized / EF Core).",
                    "SECURE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Secure insert error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertPassword_Vulnerable(string passwordValue) {
            var conn = _db.Database.GetDbConnection();

            string sql =
                $"INSERT INTO Passwords (Password) VALUES ('{passwordValue}')";

            try {
                using var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Inserted using VULNERABLE SQL (string concatenation).",
                    "VULNERABLE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (SqlException ex) {
                MessageBox.Show(
                    "SQL Injection triggered!\n\n" + ex.Message,
                    "SQL ERROR (VULNERABLE)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RefreshPasswordsGrid() {
            try {
                var list = _db.Passwords
                    .AsNoTracking()
                    .OrderByDescending(p => p.Id)
                    .Take(200)
                    .Select(p => new { p.Id, p.Password1 })
                    .ToList();

                dgvPasswordTable.DataSource = list;
            }
            catch (Exception) {
                dgvPasswordTable.DataSource = null;
            }
        }

        private void btnReloadTable_Click(object sender, EventArgs e) {
            try {
                _db.Database.ExecuteSqlRaw(
                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Passwords')
                      BEGIN
                          CREATE TABLE Passwords (
                              Id INT IDENTITY(1,1) PRIMARY KEY,
                              Password NVARCHAR(200) NOT NULL
                          )
                      END"
                );

                RefreshPasswordsGrid();
                //MessageBox.Show("Password table reloaded!", "DONE");
            }
            catch (Exception ex) {
                MessageBox.Show("Error recreating table:\n" + ex.Message);
            }
        }

        private void SqlInjectionForm_Load(object sender, EventArgs e) {
            btnReloadTable.PerformClick();
        }
    }
}
