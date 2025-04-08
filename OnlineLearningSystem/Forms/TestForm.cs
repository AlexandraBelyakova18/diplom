using System;
using System.Windows.Forms;
using OnlineLearningSystem.Models;
using OnlineLearningSystem.Data;  // Предполагается, что у вас есть пространство имен для работы с данными

namespace OnlineLearningSystem.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            LoadTests(); // Загружаем тесты при инициализации формы
        }

        private void LoadTests()
        {
            // Предположим, у вас есть метод в TestDatabase для получения всех тестов
            lstTests.DataSource = TestDatabase.GetAllTests(); // Загружаем тесты
            lstTests.DisplayMember = "Title"; // Указываем, что показывать в списке
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testCreationForm = new TestCreationForm();
            testCreationForm.ShowDialog(); // Открываем форму для создания нового теста
            LoadTests(); // После создания теста перезагружаем список тестов
        }

        private void IstTests_DoubleClick(object sender, EventArgs e)
        {
            var selectedTest = GetSelectedTest();
            if (selectedTest != null)
            {
                var testDetailsForm = new TestDetailsForm(selectedTest);
                testDetailsForm.ShowDialog(); // Открываем форму с деталями теста
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тест.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Test GetSelectedTest()
        {
            // Получаем выбранный элемент из lstTests
            if (lstTests.SelectedItem is Test selectedTest)
            {
                return selectedTest; // Возвращаем выбранный тест
            }
            return null; // Если ничего не выбрано
        }
    }
}
