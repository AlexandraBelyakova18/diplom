using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLearningSystem.Tests
{
    // Класс тестов для ContentAdvisor
    [TestClass]
    public class ContentAdvisorTests
    {
        private ContentAdvisor advisor;
        private List<Material> materials;

        [TestInitialize]
        public void Setup()
        {
            // Инициализация материалов и объекта ContentAdvisor
            materials = new List<Material>
            {
                new Material { Id = 1, Title = "Easy Material", DifficultyLevel = 1 },
                new Material { Id = 2, Title = "Medium Material", DifficultyLevel = 2 },
                new Material { Id = 3, Title = "Hard Material", DifficultyLevel = 3 },
                new Material { Id = 4, Title = "Very Hard Material", DifficultyLevel = 4 },
                new Material { Id = 5, Title = "Another Easy Material", DifficultyLevel = 1 }
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
            Assert.AreEqual(3, recommendedMaterials.Count, "Expected at least 3 recommended materials.");
            Assert.IsTrue(recommendedMaterials.Exists(m => m.Id == 1), "Easy Material should be included.");
            Assert.IsTrue(recommendedMaterials.Exists(m => m.Id == 2), "Medium Material should be included.");
            Assert.IsFalse(recommendedMaterials.Exists(m => m.Id == 3), "Hard Material should NOT be included.");
        }

        [TestMethod]
        public void GetRecommendedMaterials_WithNoMaterials_ReturnsThreeDefaultMaterials()
        {
            // Arrange
            var emptyAdvisor = new ContentAdvisor(new List<Material>());
            var userKnowledgeLevel = 1;

            // Act
            var recommendedMaterials = emptyAdvisor.GetRecommendedMaterials(userKnowledgeLevel);

            // Assert
            Assert.AreEqual(3, recommendedMaterials.Count, "Expected 3 default materials when no materials are provided.");
        }

        [TestMethod]
        public void GetRecommendedMaterials_WithAllMaterialsHard_ReturnsThreeDefaultMaterials()
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
            Assert.AreEqual(3, recommendedMaterials.Count, "Expected 3 default materials when all materials are harder than the user's knowledge level.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void GetRecommendedMaterials_WithNegativeKnowledgeLevel_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var userKnowledgeLevel = -1; // Неправильный уровень знаний

            // Act
            advisor.GetRecommendedMaterials(userKnowledgeLevel); // Убедитесь, что выбрасывается исключение
        }

        [TestMethod]
        public void GetRecommendedMaterials_WithHighKnowledgeLevel_ReturnsAllMaterials()
        {
            // Arrange
            var userKnowledgeLevel = 5; // Больше, чем максимальный уровень сложности материалов

            // Act
            var recommendedMaterials = advisor.GetRecommendedMaterials(userKnowledgeLevel);

            // Assert
            Assert.AreEqual(materials.Count, recommendedMaterials.Count, "Expected all materials to be recommended for high knowledge level.");
        }
    }

    // Класс Material
    public class Material
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DifficultyLevel { get; set; }
    }

    // Класс ContentAdvisor
    public class ContentAdvisor
    {
        private readonly List<Material> materials;

        public ContentAdvisor(List<Material> materials)
        {
            this.materials = materials ?? throw new ArgumentNullException(nameof(materials));
        }

        public List<Material> GetRecommendedMaterials(int knowledgeLevel)
        {
            if (knowledgeLevel < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(knowledgeLevel), "Knowledge level cannot be negative.");
            }

            // Фильтрация материалов по уровню знаний
            var recommended = materials.Where(m => m.DifficultyLevel <= knowledgeLevel).ToList();

            // Если материалов недостаточно, добавьте простые материалы по умолчанию
            if (recommended.Count < 3)
            {
                // Получаем простые материалы
                var defaultMaterials = materials.Where(m => m.DifficultyLevel == 1).ToList();
                // Добавляем недостающие материалы
                recommended.AddRange(defaultMaterials.Take(3 - recommended.Count));
            }

            // Возвращаем список материалов, которые должны быть хотя бы 3
            return recommended.Distinct().Take(3).ToList(); // Ограничиваем до 3
        }
    }
}
