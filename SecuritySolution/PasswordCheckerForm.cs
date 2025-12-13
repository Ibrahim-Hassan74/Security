using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Security
{
    public partial class PasswordCheckerForm : KryptonForm
    {
        public PasswordCheckerForm()
        {
            InitializeComponent();
            InternalPanel.StateCommon.Color1 = Color.FromArgb(240, 240, 240);
            InternalPanel.StateCommon.Color2 = Color.FromArgb(240, 240, 240);
            txtPassword.TextChanged += txtPassword_TextChanged;
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword.Tag?.ToString())
                return;

            UpdatePasswordStrengthUI();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password first.");
                return;
            }

            var eval = GetEvaluation(password);

            lblStrength.Text = $"Strength Score: {eval.Score}/100";

            SetLabelState(lblHasLower, eval.HasLower, "Has Lowercase ✓", "No Lowercase ✗");
            SetLabelState(lblHasUpper, eval.HasUpper, "Has Uppercase ✓", "No Uppercase ✗");
            SetLabelState(lblHasNumber, eval.HasNumber, "Has Number ✓", "No Numbers ✗");
            SetLabelState(lblHasSymbol, eval.HasSymbol, "Has Symbol ✓", "No Symbols ✗");

            if (eval.Score < 40)
                lblStrength.ForeColor = Color.Red;
            else if (eval.Score < 70)
                lblStrength.ForeColor = Color.Orange;
            else
                lblStrength.ForeColor = Color.Green;
        }

        private void SetLabelState(Label lbl, bool condition, string okText, string badText)
        {
            lbl.Text = condition ? okText : badText;
            lbl.ForeColor = condition ? Color.Green : Color.Red;
        }

        public class Evaluation
        {
            public int Score { get; set; }
            public bool HasLower { get; set; }
            public bool HasUpper { get; set; }
            public bool HasNumber { get; set; }
            public bool HasSymbol { get; set; }
            public double Entropy { get; set; }
        }
        static Evaluation GetEvaluation(string password, bool isRealTime = false)
        {
            bool PasswordExists(string plaintext)
            {
                var ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                if (plaintext == null) throw new ArgumentNullException(nameof(plaintext));

                byte[] hash;
                using (var sha = SHA1.Create())
                {
                    hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(plaintext.Trim()));
                }

                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                const int HASH_BYTES = 20;
                using var cmd = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT 1 FROM dbo.pwned_passwords WHERE passwords = @h) THEN 1 ELSE 0 END", conn);
                var p = cmd.Parameters.Add("@h", SqlDbType.Binary, HASH_BYTES);
                p.Value = hash;

                object? res = cmd.ExecuteScalar();
                conn.Close();

                if (res == null || res == DBNull.Value) return false;
                return Convert.ToInt32(res) == 1;
            }

            int score = 0;
            if (password.Length < 6)
                score -= 10000000;
            if (password.Length < 8)
                score -= 20;

            if (!isRealTime)
            {
                if (PasswordExists(password))
                    score -= 10000000;
            }

            if (password.Length >= 8)
                score += 5;
            if (password.Length >= 12)
                score += 10;

            var eval = new Evaluation();
            int charSetSize = 0;

            if (password.Any(char.IsUpper))
            {
                score += 10;
                eval.HasUpper = true;
                charSetSize += 26;
            }
            else score -= 10;

            if (password.Any(char.IsLower))
            {
                score += 10;
                eval.HasLower = true;
                charSetSize += 26;
            }
            else score -= 10;

            if (password.Any(char.IsNumber))
            {
                score += 10;
                eval.HasNumber = true;
                charSetSize += 10;
            }
            else score -= 10;

            string symbols = "!@#$%^&*()-_=+[]{};:'\",.<>?/\\|`~";
            if (password.Any(c => symbols.Contains(c)))
            {
                score += 15;
                eval.HasSymbol = true;
                charSetSize += symbols.Length;
            }
            else score -= 15;

            double entropy = password.Length * Math.Log2(charSetSize);
            eval.Entropy = entropy;

            if (entropy >= 40 && entropy < 60) score += 10;
            else if (entropy >= 60 && entropy < 80) score += 20;
            else if (entropy >= 80 && entropy < 100) score += 30;
            else if (entropy >= 100) score += 40;

            score = Math.Clamp(score, 0, 100);
            eval.Score = score;
            return eval;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;

            txtPassword.Text = txtPassword.Tag?.ToString() ?? "";
            txtPassword.StateCommon.Content.Color1 = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;

            lblStrength.Text = "";
            lblHasUpper.Text = "";
            lblHasLower.Text = "";
            lblHasNumber.Text = "";
            lblHasSymbol.Text = "";

            Color defaultColor = Color.Gray;

            lblStrength.ForeColor = defaultColor;
            lblHasUpper.ForeColor = defaultColor;
            lblHasLower.ForeColor = defaultColor;
            lblHasNumber.ForeColor = defaultColor;
            lblHasSymbol.ForeColor = defaultColor;
        }
        private void UpdatePasswordStrengthUI()
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                lblStrength.Text = "";
                lblHasUpper.Text = "";
                lblHasLower.Text = "";
                lblHasNumber.Text = "";
                lblHasSymbol.Text = "";
                return;
            }

            var eval = GetEvaluation(password);

            //lblStrength.Text = $"Strength Score: {eval.Score}/100";

            SetLabelState(lblHasLower, eval.HasLower, "Has Lowercase ✓", "No Lowercase ✗");
            SetLabelState(lblHasUpper, eval.HasUpper, "Has Uppercase ✓", "No Uppercase ✗");
            SetLabelState(lblHasNumber, eval.HasNumber, "Has Number ✓", "No Numbers ✗");
            SetLabelState(lblHasSymbol, eval.HasSymbol, "Has Symbol ✓", "No Symbols ✗");

            //if (eval.Score < 40)
            //    lblStrength.ForeColor = Color.Red;
            //else if (eval.Score < 70)
            //    lblStrength.ForeColor = Color.Orange;
            //else
            //    lblStrength.ForeColor = Color.Green;

        }

    }
}

