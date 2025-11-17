using ComponentFactory.Krypton.Toolkit;

namespace securite
{
    public partial class Form1 : KryptonForm
    {
        //private string _fullText = "Secure Login - Cyber Security System";
        private string _fullText =
            "Initializing Security Protocols...\n" +
            "Establishing Encrypted Connection...\n" +
            "AI Firewall Active...\n" +
            "User Authentication Required...\n" +
            "Please Enter Your Credentials.";

        private int _currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            lblTitle.Text = string.Empty;  
            typeTimer.Interval = 60;       
            typeTimer.Start();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void typeTimer_Tick(object sender, System.EventArgs e)
        {
            if (_currentIndex < _fullText.Length)
            {
                lblTitle.Text += _fullText[_currentIndex];
                _currentIndex++;
            }
            else
            {
                typeTimer.Stop();
            }
        }
    }
}
