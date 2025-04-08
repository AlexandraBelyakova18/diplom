using System;
using System.Linq;
using System.Windows.Forms;
using OnlineLearningSystem.Models;

namespace OnlineLearningSystem.Forms
{
    public partial class TestDetailsForm : Form
    {
        private Test selectedTest;

        public TestDetailsForm(Test test)
        {
            InitializeComponent();
            selectedTest = test;
            LoadTestDetails();
        }

        private void LoadTestDetails()
        {
            lblTestTitle.Text = selectedTest.Title;
            txtQuestions.Text = string.Join(Environment.NewLine, selectedTest.Questions.Select(q => q.Text)); // Извлечение текста вопросов
        }

        private void txtQuestions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
