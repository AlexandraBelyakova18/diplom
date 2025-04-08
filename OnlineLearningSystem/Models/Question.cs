using System.Collections.Generic;

namespace OnlineLearningSystem.Models
{
    public class Question
    {
        public string Text { get; set; } // Текст вопроса
        public List<Answer> Answers { get; set; } // Варианты ответов

        public Question()
        {
            Answers = new List<Answer>();
        }
    }
}
