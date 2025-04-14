using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace OnlineLearningSystem.Tests
{
    [TestClass]
    public class Test1
    {
        private ContentAdvisor advisor;

        // Данные для тестов
        private List<Material> materials;

        [TestInitialize] // Этот метод будет выполняться перед каждым тестом
        public void Setup()
        {
            materials = new List<Material>
            {
                new Material { Id = 1, Title = "Easy Material", DifficultyLevel = 1 },
                new Material { Id = 2, Title = "Medium Material", DifficultyLevel = 2 },
                new Material { Id = 3, Title = "Hard Material", DifficultyLevel = 3 },
                new Material { Id = 4, Title = "Very Hard Material", DifficultyLevel = 4 }
            };

            advisor = new ContentAdvisor(materials);
        }

        [TestMethod]
        public void GetRecommendedMaterials_WithMultipleMaterials_ReturnsCorrectMaterials()
        {
            // Arrange
            var userKnowledgeLevel = 2;

            // Act
            var recommendedMaterials = advisor.GetRecommendedMaterials(userKnowledgeLevel);

            // Assert
            Assert.AreEqual(2, recommendedMaterials.Count);
            Assert.IsTrue(recommendedMaterials.Exists(m => m.Id == 1));
            Assert.IsTrue(recommendedMaterials.Exists(m => m.Id == 2));
            Assert.IsFalse(recommendedMaterials.Exists(m => m.Id == 3));
        }

        [TestMethod]
        public void GetRecommendedMaterials_WithNoMaterials_ReturnsEmptyList()
        {
            // Arrange
            var emptyAdvisor = new ContentAdvisor(new List<Material>());
            var userKnowledgeLevel = 1;

            // Act
            var recommendedMaterials = emptyAdvisor.GetRecommendedMaterials(userKnowledgeLevel);

            // Assert
            Assert.AreEqual(0, recommendedMaterials.Count);
        }

        [TestMethod]
        public void GetRecommendedMaterials_WithAllMaterialsHard_ReturnsEmptyList()
        {
            // Arrange
            var userKnowledgeLevel = 2;
            var hardMaterials = new List<Material>
            {
                new Material { Id = 3, Title = "Hard Material", DifficultyLevel = 3 },
                new Material { Id = 4, Title = "Very Hard Material", DifficultyLevel = 4 }
            };
            var hardAdvisor = new ContentAdvisor(hardMaterials);

            // Act
            var recommendedMaterials = hardAdvisor.GetRecommendedMaterials(userKnowledgeLevel);

            // Assert
            Assert.AreEqual(0, recommendedMaterials.Count);
        }
    }
}
