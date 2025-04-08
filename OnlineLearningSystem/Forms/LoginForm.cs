using System;
using System.Windows.Forms;
using OnlineLearningSystem.Data; // Доступ к классу, работающему с базой данных
using OnlineLearningSystem.Models; // Доступ к моделям данных

namespace OnlineLearningSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Проверка, заполнены ли поля ввода
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Валидация учетных данных пользователя
                var user = UserDatabase.ValidateUser(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    Form dashboard = null;

                    switch (user.Role)
                    {
                        case "Администратор":
                            dashboard = new AdminDashboardForm();
                            break;
                        case "Преподаватель":
                            dashboard = new TeacherDashboardForm();
                            break;
                        case "Студент":
                            dashboard = new StudentDashboardForm(user); // Передаем пользователя
                            break;
                        default:
                            MessageBox.Show("Неизвестная роль пользователя.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Показываем соответствующую панель
                    if (dashboard != null)
                    {
                        dashboard.Show();
                        this.Hide(); // Скрыть форму входа
                    }
                }
                else
                {
                    MessageBox.Show("Неверные учетные данные", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при входе: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
