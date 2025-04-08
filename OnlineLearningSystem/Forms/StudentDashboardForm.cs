using System;
using System.Linq;
using System.Windows.Forms;
using OnlineLearningSystem.Data; // Для доступа к базе данных тестов и материалов
using OnlineLearningSystem.Models; // Для доступа к моделям данных

namespace OnlineLearningSystem.Forms
{
    public partial class StudentDashboardForm : Form
    {
        private User currentUser; // Текущий пользователь

        public StudentDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user; // Сохраняем текущего пользователя
            DisplayUserInfo(); // Отображаем информацию о пользователе

            // Подписка на события
            lstAvailableMaterials.SelectedIndexChanged += LstAvailableMaterials_SelectedIndexChanged;
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            // Обновление доступных тестов и материалов при загрузке формы
            RefreshAvailableTests();
            RefreshAvailableMaterials(); // Обновляем список доступных материалов
        }

        private void DisplayUserInfo()
        {
            lblUserName.Text = $"Привет, {currentUser.Username}!";
            lblKnowledgeLevel.Text = $"Ваш уровень знаний: {currentUser.KnowledgeLevel}"; // Отображаем уровень знаний
        }

        private void RefreshAvailableTests()
        {
            lstAvailableTests.Items.Clear(); // Очищаем список доступных тестов

            // Получаем доступные тесты для студентов
            var availableTests = TestDatabase.GetTestsForStudents();
            if (availableTests.Any())
            {
                foreach (var test in availableTests)
                {
                    lstAvailableTests.Items.Add(test.Title); // Добавляем название теста в список
                }
            }
            else
            {
                MessageBox.Show("Нет доступных тестов.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshAvailableMaterials()
        {
            lstAvailableMaterials.Items.Clear(); // Очищаем список доступных материалов

            // Получаем доступные материалы
            var availableMaterials = MaterialManager.GetMaterials();

            if (availableMaterials != null)
            {
                // Фильтруем материалы по уровню знаний пользователя
                var recommendedMaterials = availableMaterials
                    .Where(m => m.DifficultyLevel <= currentUser.KnowledgeLevel) // Получаем соответствующие материалы
                    .ToList();

                if (recommendedMaterials.Any())
                {
                    foreach (var material in recommendedMaterials)
                    {
                        lstAvailableMaterials.Items.Add(material.Title); // Добавляем название материала в список
                    }
                }
                else
                {
                    MessageBox.Show("Нет доступных материалов для вашего уровня знаний.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Не удалось получить доступные материалы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик выбора материала
        private void LstAvailableMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Загрузка информации о выбранном материале, если требуется
            if (lstAvailableMaterials.SelectedItem != null)
            {
                var selectedMaterialTitle = lstAvailableMaterials.SelectedItem.ToString();
                var availableMaterials = MaterialManager.GetMaterials();

                if (availableMaterials != null)
                {
                    var selectedMaterial = availableMaterials
                        .FirstOrDefault(m => m.Title == selectedMaterialTitle);

                    // Теперь используем свойство Content, если Description не существует
                    if (selectedMaterial != null)
                    {
                        MessageBox.Show(selectedMaterial.Content, selectedMaterial.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось получить список материалов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработчик нажатия кнопки тестирования
        private void BtnTakeTest_Click(object sender, EventArgs e)
        {
            if (lstAvailableTests.SelectedItem != null)
            {
                var selectedTestTitle = lstAvailableTests.SelectedItem.ToString();
                var selectedTest = TestDatabase.GetTestsForStudents()
                    .FirstOrDefault(t => t.Title == selectedTestTitle);

                if (selectedTest != null)
                {
                    // Создаем форму тестирования с одним аргументом
                    TestTakingForm testTakingForm = new TestTakingForm(selectedTest);
                    testTakingForm.Show(); // Показываем форму тестирования
                    this.Hide(); // Скрываем текущую форму
                }
                else
                {
                    MessageBox.Show("Тест не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тест для прохождения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
