namespace OnlineLearningSystem.Models
{
    public class ContentAdaptationPolicy
    {
        public int MinKnowledgeLevel { get; set; } // Минимальный уровень знаний
        public int MaxKnowledgeLevel { get; set; } // Максимальный уровень знаний
        public int DifficultyLevel { get; set; } // Уровень сложности материала
        public Material Material { get; set; } // Связанный материал

        // Конструктор с параметрами
        public ContentAdaptationPolicy(int minKnowledgeLevel, int maxKnowledgeLevel, int difficultyLevel, Material material)
        {
            MinKnowledgeLevel = minKnowledgeLevel;
            MaxKnowledgeLevel = maxKnowledgeLevel;
            DifficultyLevel = difficultyLevel;
            Material = material;
        }

        // Конструктор по умолчанию
        public ContentAdaptationPolicy() { }
    }
}
