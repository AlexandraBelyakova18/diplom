using System;
using System.Windows.Forms;
using OnlineLearningSystem.Models;
using OnlineLearningSystem.Data;

namespace OnlineLearningSystem.Forms
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            LoadCourses(); // Загружаем курсы при открытии формы
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var newCourse = new Course
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text
            };

            CourseManager.AddCourse(newCourse); // Добавляем новый курс
            LoadCourses(); // Обновляем список курсов
        }

        private void LoadCourses()
        {
            listBoxCourses.Items.Clear();
            var courses = CourseManager.GetCourses();
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add(course); // Добавляем курс в список
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
