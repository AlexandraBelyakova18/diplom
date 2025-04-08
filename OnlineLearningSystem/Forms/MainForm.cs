using System;
using System.Linq; // Используется для доступа к FirstOrDefault
using System.Windows.Forms;
using OnlineLearningSystem.Forms;
using OnlineLearningSystem.Data; // Необходимо для доступа к TestDatabase

namespace OnlineLearningSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testCreationForm = new TestCreationForm();
            testCreationForm.ShowDialog(); // Показываем диалог для создания теста
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog(); // Показываем статистику
        }

        private void btnViewTests_Click(object sender, EventArgs e)
        {
            var testForm = new TestForm();
            testForm.ShowDialog(); // Показываем список тестов
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            var tests = TestDatabase.GetAllTests(); // Получаем все доступные тесты
            var selectedTest = tests.FirstOrDefault(); // Берём первый тест для демонстрации

            if (selectedTest != null)
            {
                var testTakingForm = new TestTakingForm(selectedTest); // Передаём тест в форму
                testTakingForm.ShowDialog(); // Показываем форму для прохождения теста
            }
            else
            {
                MessageBox.Show("Нет доступных тестов для прохождения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполнен при загрузке формы
        }
    }
}
