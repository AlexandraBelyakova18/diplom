using System;
using System.Windows.Forms;

namespace OnlineLearningSystem.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();

            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
