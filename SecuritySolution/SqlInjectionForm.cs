using Krypton.Toolkit;
using Microsoft.Data.SqlClient; // for ADO fallback
using Microsoft.EntityFrameworkCore;
using Security.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Security
{
    public partial class SqlInjectionForm : KryptonForm
    {
        private readonly ApplicationDbContext _db;

        public SqlInjectionForm(ApplicationDbContext db)
        {
            _db = db;
            InitializeComponent();

            lblText.Text = "TEXT:";
            btnInject.Text = "Try Inject";
            chkInject.Text = "Inject";
            txtQuery.Tag = "Enter key here";
            SetPlaceholder(txtQuery, txtQuery.Tag?.ToString() ?? "");
            RefreshPasswordsGrid();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var txt = sender as KryptonTextBox;
            if (txt == null) return;
            string placeholder = txt.Tag?.ToString() ?? "";
            RemovePlaceholder(txt, placeholder);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var txt = sender as KryptonTextBox;
            if (txt == null) return;
            string placeholder = txt.Tag?.ToString() ?? "";
            SetPlaceholder(txt, placeholder);
        }

        private void SetPlaceholder(KryptonTextBox txt, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void RemovePlaceholder(KryptonTextBox txt, string placeholder)
        {
            if (txt.Text == placeholder)
            {
                txt.Text = "";
                txt.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            string placeholder = txtQuery.Tag?.ToString() ?? "";
            string input = txtQuery.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(input) || input == placeholder)
            {
                MessageBox.Show("Please enter a query or password in the text box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkInject.Checked)
            {
                InsertPassword_Vulnerable(input);
            }
            else
            {
                InsertPassword_Secure(input);
            }
            RefreshPasswordsGrid();


            //var conn = _db.Database.GetDbConnection();

            //try
            //{
            //    //if (!(conn is SqlConnection sqlConn))
            //    //{
            //    //    MessageBox.Show("Database connection is not a SqlConnection. This executor expects SQL Server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    return;
            //    //}

            //    //using (var cmd = sqlConn.CreateCommand())
            //    //{
            //    //    cmd.CommandText = input;
            //    //    cmd.CommandType = CommandType.Text;
            //    //    if (sqlConn.State != ConnectionState.Open) sqlConn.Open();

            //    //    using (var reader = cmd.ExecuteReader(CommandBehavior.Default))
            //    //    {
            //    //        var resultTables = new List<DataTable>();
            //    //        int resultSetIndex = 0;
            //    //        do
            //    //        {
            //    //            var table = new DataTable();
            //    //            if (reader.HasRows)
            //    //            {
            //    //                table.Load(reader);
            //    //                resultTables.Add(table);
            //    //            }
            //    //            else
            //    //            {
            //    //                resultTables.Add(table);
            //    //            }

            //    //            resultSetIndex++;
            //    //        } while (!reader.IsClosed && reader.NextResult());

            //    //        int recordsAffected = reader.RecordsAffected;

            //    //        DataTable firstNonEmpty = resultTables.FirstOrDefault(t => t.Rows.Count > 0);

            //    //        if (firstNonEmpty != null)
            //    //        {
            //    //            dgvPasswords.DataSource = firstNonEmpty;
            //    //            MessageBox.Show($"Executed. Result sets: {resultTables.Count}. First non-empty result set rows: {firstNonEmpty.Rows.Count}.", "Executed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //        }
            //    //        else
            //    //        {
            //    //            dgvPasswords.DataSource = null;
            //    //            MessageBox.Show($"Executed. Result sets: {resultTables.Count}. Rows affected (if applicable): {recordsAffected}", "Executed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //        }
            //    //    }
            //    //}
            //}
            //catch (SqlException sqlEx)
            //{
            //    MessageBox.Show("SQL error:\n" + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Execution error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    RefreshPasswordsGrid();
            //}
        }

        private void InsertPassword_Secure(string passwordValue)
        {
            try
            {
                var pw = new Password { Password1 = passwordValue };
                _db.Passwords.Add(pw);
                _db.SaveChanges();

                MessageBox.Show(
                    "Inserted safely (parameterized / EF Core).",
                    "SECURE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Secure insert error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertPassword_Vulnerable(string passwordValue)
        {
            var conn = _db.Database.GetDbConnection();

            string sql =
                $"INSERT INTO Passwords (Password) VALUES ('{passwordValue}')";

            try
            {
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
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "SQL Injection triggered!\n\n" + ex.Message,
                    "SQL ERROR (VULNERABLE)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InsertPasswordAndRefresh(string passwordValue, string successMessage)
        {
            try
            {
                var pw = new Password { Password1 = passwordValue };
                _db.Passwords.Add(pw);
                _db.SaveChanges();

                MessageBox.Show(successMessage, "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPasswordsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting password:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshPasswordsGrid()
        {
            try
            {
                var list = _db.Passwords
                    .AsNoTracking()
                    .OrderByDescending(p => p.Id)
                    .Take(200)
                    .Select(p => new { p.Id, p.Password1 })
                    .ToList();

                dgvPasswords.DataSource = list;
            }
            catch (Exception)
            {
                dgvPasswords.DataSource = null;
            }
        }

    }
}
