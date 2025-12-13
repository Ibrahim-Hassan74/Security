using Krypton.Toolkit;
using Security.Algorithms;
using Security.Service;
using Security.ServiceContract;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Security
{
    public partial class CipherAlgorithmsForm : KryptonForm
    {
        private readonly ICipherFactory _factory;
        private string lastCipherText;
        private string lastAlgorithmId;
        private string lastKeyUsed;
        private bool currentlyEncrypted = false;

        public CipherAlgorithmsForm(ICipherFactory factory)
        {
            _factory = factory;
            InitializeComponent();
            PopulateAlgorithms();
        }

        private void PopulateAlgorithms()
        {
            comboBoxAlgorithms.Items.Clear();

            foreach (var svc in _factory.Available)
                comboBoxAlgorithms.Items.Add(svc);

            comboBoxAlgorithms.DisplayMember = "Name";
            comboBoxAlgorithms.SelectedIndex = 0;
            UpdateUIForSelectedAlgorithm();
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


        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            try
            {
                var svc = comboBoxAlgorithms.SelectedItem as ICipherService;
                if (svc == null) return;

                var generated = svc.GenerateKey();
                if (string.IsNullOrEmpty(generated))
                {
                    MessageBox.Show("This algorithm cannot generate a key automatically.", "Generate Key", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtKey.Text = generated;
                lastKeyUsed = generated;
                lblStatus.Text = $"Generated key for {svc.Name}.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate key: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            var svc = comboBoxAlgorithms.SelectedItem as ICipherService;
            if (svc == null)
            {
                MessageBox.Show("Select an algorithm first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (svc.Name == "Polyalphabetic (Vigenère)")
            {
                string key = txtKey.Text;
                if (!string.IsNullOrEmpty(key))
                {
                    foreach (char c in key)
                    {
                        if (!char.IsLetter(c))
                        {
                            MessageBox.Show("The key for Vigenère cipher must contain only letters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            try
            {
                if (!currentlyEncrypted)
                {
                    var plain = txtInput.Text ?? string.Empty;
                    if (string.IsNullOrWhiteSpace(plain))
                    {
                        MessageBox.Show("Enter text to encrypt.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (svc.RequiresKey && string.IsNullOrWhiteSpace(txtKey.Text))
                    {
                        MessageBox.Show("This algorithm requires a key. Please enter it.", "Key required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string keyToPass = string.IsNullOrWhiteSpace(txtKey.Text) ? null : txtKey.Text;

                    var result = svc.Encrypt(plain, keyToPass);

                    lastCipherText = result.Ciphertext;
                    lastAlgorithmId = result.AlgorithmId;
                    lastKeyUsed = result.UsedKey;

                    txtInput.Text = result.Ciphertext;
                    currentlyEncrypted = true;
                    btnEncryptDecrypt.Text = "Decrypt";
                    lblStatus.Text = $"Encrypted with {svc.Name}.";
                    btnGenerateKey.Enabled = false;
                    txtKey.Enabled = false;
                    if (svc is PlayFairService)
                    {
                        listDecryption.Visible = false;
                        listDecryption.Items.Clear();
                    }
                    if (svc is CaesarService)
                    {
                        listDecryption.Visible = true;
                        bruteForce.Visible = true;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(lastCipherText) || string.IsNullOrEmpty(lastAlgorithmId))
                    {
                        MessageBox.Show("No ciphertext stored. Please encrypt first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var svcForDecrypt = _factory.GetById(lastAlgorithmId);
                    string keyToUse = string.IsNullOrWhiteSpace(txtKey.Text) ? (lastKeyUsed ?? "") : txtKey.Text;

                    if (svcForDecrypt.RequiresKey && string.IsNullOrWhiteSpace(keyToUse))
                    {
                        MessageBox.Show("Key required to decrypt. Provide the key.", "Key Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var plain = svcForDecrypt.Decrypt(lastCipherText, keyToUse);
                    txtInput.Text = plain;

                    if (svcForDecrypt is PlayFairService pfService)
                    {
                        listDecryption.Visible = true;
                        listDecryption.Items.Clear();

                        foreach (var w in pfService.LastCloseWords)
                        {
                            listDecryption.Items.Add(w);
                        }
                    }

                    if (svcForDecrypt is CaesarService)
                    {
                        listDecryption.Items.Clear();
                        listDecryption.Visible = false;
                        bruteForce.Visible = false;
                    }
                    currentlyEncrypted = false;
                    btnEncryptDecrypt.Text = "Encrypt";
                    lblStatus.Text = $"Decrypted (algorithm: {svcForDecrypt.Name}).";
                    btnGenerateKey.Enabled = true;
                    txtKey.Enabled = true;
                    bruteForce.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtKey.Clear();
            lastCipherText = null;
            lastAlgorithmId = null;
            listDecryption.Items.Clear();
            listDecryption.Visible = false;
            lastKeyUsed = null;
            currentlyEncrypted = false;
            btnEncryptDecrypt.Text = "Encrypt";
            lblStatus.Text = "Ready";
            bruteForce.Visible = false;
            btnGenerateKey.Enabled = true;
            txtKey.Enabled = true;
        }
        private void comboBoxAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtKey.Clear();
            listDecryption.Items.Clear();
            listDecryption.Visible = false;
            bruteForce.Visible = false;

            SetPlaceholder(txtInput, txtInput.Tag?.ToString() ?? "");
            SetPlaceholder(txtKey, txtKey.Tag?.ToString() ?? "");

            lastCipherText = null;
            lastKeyUsed = null;
            lastAlgorithmId = null;
            currentlyEncrypted = false;

            btnEncryptDecrypt.Text = "Encrypt";

            UpdateUIForSelectedAlgorithm();

            lblStatus.Text = "Ready";
        }


        private void UpdateUIForSelectedAlgorithm()
        {
            var svc = comboBoxAlgorithms.SelectedItem as ICipherService;
            if (svc == null)
                return;

            if (svc is HillService || svc is MonoAlphabeticService || svc is AffineService)
            {
                txtKey.Enabled = true;
                btnGenerateKey.Visible = true;
            }
            else
            {
                txtKey.Enabled = true;
                btnGenerateKey.Visible = false;
            }

            lblKeyHint.Text = $"Hint: {svc.KeyHint ?? "No key required"}";

            lblAlgorithmInfo.Text =
                $"Algorithm: {svc.Name}\nRequires Key: {(svc.RequiresKey ? "Yes" : "No")}";

            lblKeyValidation.Text = "";

            SetPlaceholder(txtKey, txtKey.Tag?.ToString() ?? "");
            SetPlaceholder(txtInput, txtInput.Tag?.ToString() ?? "");
        }

        private void bruteForce_Click(object sender, EventArgs e)
        {
            var svcForDecrypt = _factory.GetById("Caesar");
            if (svcForDecrypt is CaesarService pfService)
            {
                var svc = comboBoxAlgorithms.SelectedItem as ICipherService;
                listDecryption.Items.Clear();
                var inputText = txtInput.Text;
                var selectedText = svc.Decrypt(inputText, txtKey.Text);
                var listDecryptionResults = CaesarCipher.Decrypt(inputText);
                foreach (var w in listDecryptionResults)
                {
                    listDecryption.Items.Add(w);
                    if (w == selectedText)
                    {
                        listDecryption.SelectedItem = w;
                        listDecryption.ItemStyle = ButtonStyle.Standalone;
                    }
                }
            }
        }

        private void CipherAlgorithmsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

