using System.Collections.Generic;

namespace OnlineLearningSystem.Models
{
    public class Course
    {
        public int Id { get; set; } // Уникальный идентификатор курса
        public string Title { get; set; } // Название курса
        public string Description { get; set; } // Описание курса
        public bool IsAvailableForStudents { get; set; } // Доступен ли курс для студентов
        public List<Material> Materials { get; set; } // Список материалов курса

        public Course()
        {
            Materials = new List<Material>();
            IsAvailableForStudents = true; // По умолчанию курс доступен для студентов
        }
    }
}
