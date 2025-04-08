using System;
using System.Windows.Forms;
using OnlineLearningSystem.Data;
using OnlineLearningSystem.Models;

namespace OnlineLearningSystem.Forms

{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cmbRole.SelectedItem.ToString()
                };

                UserDatabase.RegisterUser(newUser);
                MessageBox.Show("Регистрация успешна!");

                var loginForm = new LoginForm(); // Перенаправление на форму логина
                loginForm.Show();
                this.Close(); // Закрыть форму регистрации
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
