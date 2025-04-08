namespace OnlineLearningSystem.Models
{
    public class Material
    {
        public int Id { get; set; } // Уникальный идентификатор материала
        public string Title { get; set; } // Заголовок материала
        public string Content { get; set; } // Содержимое материала
        public int DifficultyLevel { get; set; } // Уровень сложности материала

        // Конструктор с параметрами
        public Material(int id, string title, string content, int difficultyLevel)
        {
            Id = id;
            Title = title;
            Content = content;
            DifficultyLevel = difficultyLevel;
        }

        // Конструктор по умолчанию
        public Material() : this(0, "Новый материал", "Введите содержание здесь...", 1)
        {
            // Вызываем конструктор с параметрами по умолчанию
        }

        // Метод для получения краткой информации о материале
        public string GetShortInfo()
        {
            return $"{Title} (Уровень: {DifficultyLevel})";
        }

        public override string ToString()
        {
            return Title; // Чтобы при добавлении в listBox отображался только заголовок
        }
    }
}
