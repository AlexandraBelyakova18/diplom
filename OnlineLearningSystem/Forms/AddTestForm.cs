using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineLearningSystem.Models;

namespace OnlineLearningSystem.Forms
{
    public partial class AddTestForm : Form
    {
        private List<Question> questions; // Список вопросов для текущего теста

        public AddTestForm()
        {
            InitializeComponent();
            questions = new List<Question>(); // Инициализация списка вопросов
            SetPlaceholder(txtTestTitle, "Введите название теста...");
            SetPlaceholder(txtTestDescription, "Введите описание теста...");
            SetPlaceholder(txtQuestion, "Введите текст вопроса...");
            SetPlaceholder(txtAnswerA, "Ответ A");
            SetPlaceholder(txtAnswerB, "Ответ B");
            SetPlaceholder(txtAnswerC, "Ответ C");
            SetPlaceholder(txtAnswerD, "Ответ D");
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

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            // Логика добавления вопроса
            var question = new Question
            {
                Text = txtQuestion.Text,
                Answers = new List<Answer>
                {
                    new Answer { Text = txtAnswerA.Text, IsCorrect = cmbCorrectAnswer.SelectedItem?.ToString() == txtAnswerA.Text },
                    new Answer { Text = txtAnswerB.Text, IsCorrect = cmbCorrectAnswer.SelectedItem?.ToString() == txtAnswerB.Text },
                    new Answer { Text = txtAnswerC.Text, IsCorrect = cmbCorrectAnswer.SelectedItem?.ToString() == txtAnswerC.Text },
                    new Answer { Text = txtAnswerD.Text, IsCorrect = cmbCorrectAnswer.SelectedItem?.ToString() == txtAnswerD.Text }
                }
            };

            // Проверяем корректность данных
            if (string.IsNullOrWhiteSpace(question.Text) || question.Answers.Count < 4 || string.IsNullOrWhiteSpace(cmbCorrectAnswer.SelectedItem?.ToString()))
            {

                MessageBox.Show("Пожалуйста, заполните все поля вопроса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            questions.Add(question); // Добавляем объект Question в список

            // Добавляем заголовок вопроса в список вопросов
            lstQuestions.Items.Add(question.Text); // Выводим текст вопроса в список

            ClearFields(); // Очищаем поля ввода
        }

        private void ClearFields()
        {
            txtQuestion.Clear();
            txtAnswerA.Clear();
            txtAnswerB.Clear();
            txtAnswerC.Clear();
            txtAnswerD.Clear();
            cmbCorrectAnswer.SelectedIndex = -1; // Сбрасываем выбор в комбобоксе
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            // Логика сохранения теста
            // Здесь можно создать тест, добавив все вопросы и информацию о тесте
        }
    }
}
