using System;
using System.Windows.Forms;
using OnlineLearningSystem.Data;

namespace OnlineLearningSystem.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            var courseForm = new CourseForm();
            courseForm.ShowDialog();
        }

        private void btnManageTests_Click(object sender, EventArgs e)
        {
            var testForm = new TestForm();
            testForm.ShowDialog(); // Используйте этот метод для работы с тестами
        }

        private void btnManageMaterials_Click(object sender, EventArgs e)
        {
            // Получение идентификатора курса, пример
            int courseId = GetSelectedCourseId();
            var materialForm = new MaterialForm(courseId);
            materialForm.ShowDialog();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private int GetSelectedCourseId()
        {
            // Вы можете реализовать логику для выбора идентификатора курса
            // Например, возвращать ID из списка курсов в интерфейсе
            return 1; // Пример
        }
    }
}
