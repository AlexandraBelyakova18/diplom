using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLearningSystem
{
    public class Material
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DifficultyLevel { get; set; }
    }

    public class ContentAdvisor
    {
        private List<Material> materials;

        public ContentAdvisor(List<Material> materialList)
        {
            // Проверка на null для защиты от неправильного использования
            if (materialList == null)
            {
                throw new ArgumentNullException(nameof(materialList), "Material list cannot be null.");
            }

            materials = materialList;
        }

        // Метод возвращает список материалов на основе уровня знаний пользователя
        public List<Material> GetRecommendedMaterials(int knowledgeLevel)
        {
            // Проверка на неправильный уровень знаний
            if (knowledgeLevel < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(knowledgeLevel), "Knowledge level cannot be negative.");
            }

            // Фильтруем и получаем материалы, соответствующие уровню знаний
            var recommended = materials.Where(m => m.DifficultyLevel <= knowledgeLevel).ToList();

            // Если недостаточно материалов, добавляем дефолтные (уровень сложности 1)
            if (recommended.Count < 3)
            {
                var defaultMaterials = materials.Where(m => m.DifficultyLevel == 1).ToList();
                recommended.AddRange(defaultMaterials.Take(3 - recommended.Count));
            }

            // Ограничиваем результат до 3 материалов (если их больше)
            return recommended.Distinct().Take(3).ToList();
        }
    }
}
