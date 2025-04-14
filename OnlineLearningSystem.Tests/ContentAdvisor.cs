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
            materials = materialList;
        }

        // Метод возвращает список материалов на основе уровня знаний пользователя
        public List<Material> GetRecommendedMaterials(int knowledgeLevel)
        {
            return materials.Where(m => m.DifficultyLevel <= knowledgeLevel).ToList();
        }
    }
}
