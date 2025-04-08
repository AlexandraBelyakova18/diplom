using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineLearningSystem.Models;
using OnlineLearningSystem.Data;

namespace OnlineLearningSystem.Forms
{
    public partial class TestCreationForm : Form
    {
        public TestCreationForm()
        {
            InitializeComponent();
            SetPlaceholder(txtTestTitle, "Название теста");
            SetPlaceholder(txtTestDescription, "Описание теста");
            SetPlaceholder(txtQuestion, "Текст вопроса");
            SetPlaceholder(txtAnswerA, "Ответ A");
            SetPlaceholder(txtAnswerB, "Ответ B");
            SetPlaceholder(txtAnswerC, "Ответ C");
            SetPlaceholder(txtAnswerD, "Ответ D");

            // Добавление элементов в комбобокс для выбора правильного ответа
            cmbCorrectAnswer.Items.AddRange(new string[] { "Ответ A", "Ответ B", "Ответ C", "Ответ D" });
        }

        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.ForeColor = System.Drawing.Color.Gray; // Цвет заполнителя
            textBox.Text = placeholderText; // Установка текста заполнителя

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = ""; // Очистка при входе
                    textBox.ForeColor = System.Drawing.Color.Black; // Цвет текста при вводе
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText; // Установка текста заполнителя
                    textBox.ForeColor = System.Drawing.Color.Gray; // Цвет заполнителя
                }
            };
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            // Проверка заполненности полей
            if (string.IsNullOrWhiteSpace(txtTestTitle.Text) ||
                string.IsNullOrWhiteSpace(txtTestDescription.Text) ||
                string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerA.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerB.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerC.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerD.Text) ||
                cmbCorrectAnswer.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание нового теста
            var newTest = new Test
            {
                Title = txtTestTitle.Text,
                Description = txtTestDescription.Text, // Добавляем описание теста
                Questions = new List<Question>() // Инициализация списка вопросов
            };

            // Создание нового вопроса
            var newQuestion = new Question
            {
                Text = txtQuestion.Text,
                Answers = new List<Answer>()
            };

            // Добавление вариантов ответа

            newQuestion.Answers.Add(new Answer { Text = txtAnswerA.Text, IsCorrect = cmbCorrectAnswer.SelectedItem.ToString() == "Ответ A" });
            newQuestion.Answers.Add(new Answer { Text = txtAnswerB.Text, IsCorrect = cmbCorrectAnswer.SelectedItem.ToString() == "Ответ B" });
            newQuestion.Answers.Add(new Answer { Text = txtAnswerC.Text, IsCorrect = cmbCorrectAnswer.SelectedItem.ToString() == "Ответ C" });
            newQuestion.Answers.Add(new Answer { Text = txtAnswerD.Text, IsCorrect = cmbCorrectAnswer.SelectedItem.ToString() == "Ответ D" });

            // Добавляем вопрос к тесту
            newTest.Questions.Add(newQuestion);

            // Сохранение теста в TestDatabase
            TestDatabase.AddTest(newTest); // Добавляем тест в базу данных тестов

            MessageBox.Show("Тест успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очистка полей после создания теста
            ClearFields();
        }

        private void ClearFields()
        {
            txtTestTitle.Text = "Название теста";
            txtTestDescription.Text = "Описание теста";
            txtQuestion.Text = "Текст вопроса";
            txtAnswerA.Text = "Ответ A";
            txtAnswerB.Text = "Ответ B";
            txtAnswerC.Text = "Ответ C";
            txtAnswerD.Text = "Ответ D";
            cmbCorrectAnswer.SelectedItem = null; // Сброс выбора правильного ответа
        }
    }
}
