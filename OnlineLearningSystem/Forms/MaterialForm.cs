using System;
using System.Windows.Forms;
using OnlineLearningSystem.Models; // Используется модель Material
using OnlineLearningSystem.Data; // Для доступа к менеджеру материалов

namespace OnlineLearningSystem.Forms
{
    public partial class MaterialForm : Form
    {
        private int courseId; // Поле для хранения идентификатора курса
        private Material selectedMaterial; // Поле для хранения выбранного материала

        public MaterialForm(int courseId) // Конструктор с параметром
        {
            InitializeComponent();
            this.courseId = courseId; // Сохраняем идентификатор курса
            LoadMaterials(); // Загружаем материалы при открытии формы
            SetPlaceholderText(txtTitle, "Заголовок материала");
            SetPlaceholderText(txtContent, "Содержимое материала");
        }

        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            // Проверяем, что поля не пустые
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый материал
            var newMaterial = new Material
            {
                Id = GenerateNewId(), // Генерация нового уникального ID
                Title = txtTitle.Text,
                Content = txtContent.Text
            };

            // Добавляем новый материал в менеджер
            try
            {
                MaterialManager.AddMaterial(newMaterial); // Добавляем материал
                LoadMaterials(); // Обновляем список материалов
                ClearInputFields(); // Очищаем поля ввода
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении материала: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaterials()
        {
            listBoxMaterials.Items.Clear(); // Очистить текущий список материалов
            var materials = MaterialManager.GetMaterials(); // Получаем список материалов
            foreach (var material in materials)
            {
                listBoxMaterials.Items.Add(material); // Добавляем материал, вызывая ToString() для отображения заголовка
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtContent.Clear();
            SetPlaceholderText(txtTitle, "Заголовок материала");
            SetPlaceholderText(txtContent, "Содержимое материала");
            selectedMaterial = null; // Сбрасываем выделение
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray; // Установить серый цвет для заполнителя
            }
        }

        private void ClearPlaceholderText(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = System.Drawing.Color.Black; // Установить черный цвет
            }
        }

        private void txtTitle_Enter(object sender, EventArgs e) => ClearPlaceholderText(txtTitle, "Заголовок материала");
        private void txtTitle_Leave(object sender, EventArgs e) => SetPlaceholderText(txtTitle, "Заголовок материала");

        private void txtContent_Enter(object sender, EventArgs e) => ClearPlaceholderText(txtContent, "Содержимое материала");
        private void txtContent_Leave(object sender, EventArgs e) => SetPlaceholderText(txtContent, "Содержимое материала");

        private int GenerateNewId()
        {
            return MaterialManager.GetMaterials().Count + 1; // Простой метод для получения уникального ID
        }

        private void ListBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMaterials.SelectedItem != null)
            {
                selectedMaterial = (Material)listBoxMaterials.SelectedItem; // Сохраняем выбранный материал
                txtTitle.Text = selectedMaterial.Title; // Заполняем заголовок
                txtContent.Text = selectedMaterial.Content; // Заполняем содержимое
            }
        }

        private void BtnUpdateMaterial_Click(object sender, EventArgs e)
        {
            if (selectedMaterial == null)
            {
                MessageBox.Show("Выберите материал для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Обновляем содержимое материала
            selectedMaterial.Title = txtTitle.Text;
            selectedMaterial.Content = txtContent.Text;

            // Обновляем материал в менеджере
            try
            {
                MaterialManager.UpdateMaterial(selectedMaterial); // Обновляем материал
                LoadMaterials(); // Обновляем список материалов
                ClearInputFields(); // Очищаем поля ввода
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении материала: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (selectedMaterial == null)
            {
                MessageBox.Show("Выберите материал для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Удаляем материал
            try
            {
                MaterialManager.DeleteMaterial(selectedMaterial.Id); // Удаляем материал
                LoadMaterials(); // Обновляем список материалов
                ClearInputFields(); // Очищаем поля ввода
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении материала: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
