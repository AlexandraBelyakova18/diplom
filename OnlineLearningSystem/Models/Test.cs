using System.Collections.Generic;

namespace OnlineLearningSystem.Models
{
    public class Test
    {
        public int Id { get; set; } // Уникальный идентификатор теста
        public string Title { get; set; } // Название теста
        public string Description { get; set; } // Описание теста
        public List<Question> Questions { get; set; } // Список вопросов теста
        public bool IsAvailableForStudents { get; set; } // Доступен ли тест для студентов

        public Test()
        {
            Questions = new List<Question>();
            IsAvailableForStudents = true; // По умолчанию тест доступен для студентов
        }
    }
}
