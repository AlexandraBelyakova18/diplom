using System;
using System.Windows.Forms;
using OnlineLearningSystem.Data; // Убедитесь, что этот класс действительно существует

namespace OnlineLearningSystem.Forms
{
    public partial class TeacherDashboardForm : Form
    {
        public TeacherDashboardForm()
        {
            InitializeComponent();
        }

        private void TeacherDashboardForm_Load(object sender, EventArgs e)
        {
            LoadTests(); // Загружаем тесты при загрузке формы
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testForm = new TestCreationForm();

            if (testForm.ShowDialog() == DialogResult.OK)
            {
                LoadTests(); // Загружаем тесты после создания нового
            }
        }

        private void LoadTests()
        {
            listBoxTests.Items.Clear(); // Очистка списка

            // Получаем все тесты
            var tests = TestDatabase.GetAllTests();

            foreach (var test in tests)
            {
                listBoxTests.Items.Add(test.Title); // Добавляем заголовки тестов в список
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            int courseId = GetSelectedCourseId(); // Получаем идентификатор курса

            var materialForm = new MaterialForm(courseId); // Передаем courseId
            materialForm.ShowDialog();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private int GetSelectedCourseId()
        {
            // Реализуйте логику получения идентификатора выбранного курса
            return 1; // Временно возвращаем 1, замените своими данными
        }
    }
}
