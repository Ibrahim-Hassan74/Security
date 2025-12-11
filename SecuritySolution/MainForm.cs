using System;
using Security.Service;
using Security.ServiceContract;
using System.Collections.Generic;
using Krypton.Toolkit;

namespace Security
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static ICipherFactory BuildFactory()
        {
            var services = new List<ICipherService>
            {
                new CaesarService(),
                new MonoAlphabeticService(),
                new PolyalphabeticService(),
                new PlayFairService(),
                new HillService(),
                new AffineService(), 
                new BeaufortService(),
                new RsaService()
            };

            return new CipherFactory(services);
        }

        private void btnPasswordCheckerForm_Click(object sender, EventArgs e)
        {
            var form = new PasswordCheckerForm();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btnSqlInjectionForm_Click(object sender, EventArgs e)
        {
            var form = new SqlInjectionForm();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void btnCipherAlgorithmsForm_Click(object sender, EventArgs e)
        {
            var factory = BuildFactory();
            var form = new CipherAlgorithmsForm(factory);
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }
    }
}

