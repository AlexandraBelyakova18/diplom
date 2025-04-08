using System.Collections.Generic;

namespace OnlineLearningSystem.Models
{
    public class AdaptationPolicy
    {
        public int Level { get; set; } // Уровень ученика
        public int MinScore { get; set; } // Минимальный проходной балл
        public List<string> RecommendedMaterials { get; set; } // Рекомендуемые материалы

        public AdaptationPolicy()
        {
            RecommendedMaterials = new List<string>(); // Инициализация списка
        }
    }
}
