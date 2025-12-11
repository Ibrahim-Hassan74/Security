using System;
using System.Drawing;
using Security.ServiceContract;
using Krypton.Toolkit;

namespace Security
{
    public partial class PasswordCheckerForm : KryptonForm
    {
        public PasswordCheckerForm()
        {
            InitializeComponent();
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

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

