using System;
using System.Windows.Forms;
using OnlineLearningSystem.Models;
using OnlineLearningSystem.Data;

namespace OnlineLearningSystem.Forms
{
    public partial class TestTakingForm : Form
    {
        private Test _test;
        private int _currentQuestionIndex = 0;
        public int TestScore { get; private set; } // Счет за тест

        public TestTakingForm(Test test)
        {
            InitializeComponent();
            _test = test ?? throw new ArgumentNullException(nameof(test));
            ShowQuestion(); // отображение первого вопроса
            this.BackColor = System.Drawing.Color.White; // Начальный цвет фона
        }

        private void ShowQuestion()
        {
            if (_currentQuestionIndex < _test.Questions.Count)
            {
                var question = _test.Questions[_currentQuestionIndex];
                lblQuestion.Text = question.Text;

                ResetAnswerRadioButtons();

                // Заполнение радиокнопок вариантами ответов
                if (question.Answers.Count > 0) rbAnswerA.Text = question.Answers[0].Text;
                if (question.Answers.Count > 1) rbAnswerB.Text = question.Answers[1].Text;
                if (question.Answers.Count > 2) rbAnswerC.Text = question.Answers[2].Text;
                if (question.Answers.Count > 3) rbAnswerD.Text = question.Answers[3].Text;

                // Установка видимости радиокнопок
                rbAnswerA.Visible = !string.IsNullOrEmpty(rbAnswerA.Text);
                rbAnswerB.Visible = !string.IsNullOrEmpty(rbAnswerB.Text);
                rbAnswerC.Visible = !string.IsNullOrEmpty(rbAnswerC.Text);
                rbAnswerD.Visible = !string.IsNullOrEmpty(rbAnswerD.Text);
            }
            else
            {
                // Завершение теста
                MessageBox.Show("Вы прошли тест! Ваш результат: " + TestScore, "Поздравляем!", MessageBoxButtons.OK);
                TestDatabase.AddSuccessfulTest(); // Увеличение счетчика успешных прохождений
                this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex >= _test.Questions.Count) return; // Если все вопросы заданы

            string selectedAnswer = GetSelectedAnswer();

            if (string.IsNullOrEmpty(selectedAnswer))
            {
                MessageBox.Show("Пожалуйста, выберите ответ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка правильности ответа
            if (IsAnswerCorrect(selectedAnswer))
            {
                MessageBox.Show("Правильный ответ!", "Результат", MessageBoxButtons.OK);
                this.BackColor = System.Drawing.Color.Green; // Успех - зеленый фон
                TestScore++; // Увеличение балла за правильный ответ
            }
            else
            {
                ShowErrorMessage();
                TestDatabase.AddFailedTest(); // Увеличение счетчика неуспешных прохождений
            }

            _currentQuestionIndex++; // Переход к следующему вопросу
            ShowQuestion(); // Показ следующего вопроса
        }

        private string GetSelectedAnswer()
        {

            if (rbAnswerA.Checked) return rbAnswerA.Text;
            if (rbAnswerB.Checked) return rbAnswerB.Text;
            if (rbAnswerC.Checked) return rbAnswerC.Text;
            if (rbAnswerD.Checked) return rbAnswerD.Text;
            return string.Empty; // Нет выбранного ответа
        }

        private bool IsAnswerCorrect(string selectedAnswer)
        {
            foreach (var answer in _test.Questions[_currentQuestionIndex].Answers)
            {
                if (answer.Text == selectedAnswer && answer.IsCorrect)
                {
                    return true; // Ответ правильный
                }
            }
            return false; // Ответ неправильный
        }

        private void ResetAnswerRadioButtons()
        {
            // Сброс выбора ответов
            rbAnswerA.Checked = false;
            rbAnswerB.Checked = false;
            rbAnswerC.Checked = false;
            rbAnswerD.Checked = false;
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show("Неправильный ответ. Попробуйте снова.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.BackColor = System.Drawing.Color.Red; // Ошибка - красный фон
        }
    }
}
