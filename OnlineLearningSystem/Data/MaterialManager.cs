using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using OnlineLearningSystem.Models; // Используем Material из Models

namespace OnlineLearningSystem.Data
{
    public static class MaterialManager
    {
        private static readonly string filePath = "materials.json"; // Путь к файлу для хранения материалов
        private static List<Material> materials; // Список материалов

        static MaterialManager()
        {
            LoadMaterials(); // Загружаем материалы при инициализации класса
        }

        public static void AddMaterial(Material material)
        {
            materials.Add(material);
            SaveMaterials(); // Сохраняем материалы после добавления
        }

        public static void UpdateMaterial(Material updatedMaterial)
        {
            // Ищем индекс материала, который нужно обновить
            var index = materials.FindIndex(m => m.Id == updatedMaterial.Id);
            if (index != -1)
            {
                materials[index] = updatedMaterial; // Обновляем материал
                SaveMaterials(); // Сохраняем изменения
            }
            else
            {
                throw new KeyNotFoundException("Материал не найден для обновления.");
            }
        }

        public static void DeleteMaterial(int materialId)
        {
            // Ищем материал по ID
            var materialToRemove = materials.Find(m => m.Id == materialId);
            if (materialToRemove != null)
            {
                materials.Remove(materialToRemove); // Удаляем материал
                SaveMaterials(); // Сохраняем изменения
            }
            else
            {
                throw new KeyNotFoundException("Материал не найден для удаления.");
            }
        }

        public static void SaveMaterials()
        {
            var json = JsonConvert.SerializeObject(materials, Formatting.Indented);
            File.WriteAllText(filePath, json); // Сохраняем материалы в файл
        }

        public static void LoadMaterials()
        {
            // Инициализация списка материалов
            materials = new List<Material>();

            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    materials = JsonConvert.DeserializeObject<List<Material>>(json) ?? new List<Material>();
                }
                catch (Exception ex)
                {
                    // Ошибка десериализации, можно добавить логирование
                    Console.WriteLine($"Ошибка при загрузке материалов: {ex.Message}");
                }
            }

        }

        public static List<Material> GetMaterials()
        {
            return materials; // Возвращаем полный список материалов
        }
    }
}
