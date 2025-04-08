using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using OnlineLearningSystem.Models;
using System;

namespace OnlineLearningSystem.Data
{
    public static class AdaptationManager
    {
        private static List<AdaptationPolicy> policies;
        private static readonly string policyFilePath = "adaptationPolicies.json"; // Файл для хранения политик адаптации

        static AdaptationManager()
        {
            LoadAdaptationPolicies(); // Загружаем политики адаптации при запуске
        }

        // Метод для загрузки политик адаптации из файла
        private static void LoadAdaptationPolicies()
        {
            if (File.Exists(policyFilePath))
            {
                try
                {
                    string json = File.ReadAllText(policyFilePath);
                    policies = JsonConvert.DeserializeObject<List<AdaptationPolicy>>(json) ?? new List<AdaptationPolicy>();
                }
                catch (Exception ex)
                {
                    // Обработка ошибок загрузки
                    System.Windows.Forms.MessageBox.Show($"Ошибка при загрузке политик адаптации: {ex.Message}", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
            {
                // Если файл не существует, создаем пустой список
                policies = new List<AdaptationPolicy>();
            }
        }

        // Метод для получения рекомендованных материалов на основании результата теста
        public static List<string> GetRecommendedMaterials(int testScore)
        {
            // Находим первую политику, которая удовлетворяет результату теста
            var policy = policies.FirstOrDefault(p => testScore >= p.MinScore);
            return policy != null ? policy.RecommendedMaterials : new List<string>(); // Возвращаем рекомендованные материалы или пустой список
        }

        // Метод для добавления новой политики адаптации
        public static void AddAdaptationPolicy(AdaptationPolicy policy)
        {
            policies.Add(policy);
            SaveAdaptationPoliciesToFile(); // Сохраняем обновленный список политик
        }

        // Метод для сохранения всех политик в файл
        private static void SaveAdaptationPoliciesToFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(policies, Formatting.Indented);
                File.WriteAllText(policyFilePath, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка при сохранении политик адаптации: {ex.Message}", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
