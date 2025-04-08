using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;
using OnlineLearningSystem.Models;
using System;

namespace OnlineLearningSystem.Data
{
    public static class TestDatabase
    {
        private static List<Test> tests = new List<Test>();
        private static int nextId = 1;
        private static readonly string filePath = "tests.json"; // Путь к файлу для тестов
        private static readonly string statsFilePath = "testStats.json"; // Путь к файлу для статистики
        private static int totalTestPasses = 0; // Количество успешных прохождений тестов
        private static int totalTestFails = 0; // Количество неуспешных прохождений тестов

        static TestDatabase()
        {
            LoadTestsFromFile(); // Загружаем тесты из файла при запуске
            LoadStatisticsFromFile(); // Загружаем статистику из файла
        }

        public static void AddTest(Test test)
        {
            test.Id = nextId++;
            tests.Add(test);
            SaveTestsToFile(); // Сохраняем изменения в файл
        }

        public static List<Test> GetAllTests()
        {
            return tests; // Возвращаем текущий список всех тестов
        }

        public static List<Test> GetTestsForStudents()
        {
            return tests.Where(test => test.IsAvailableForStudents).ToList(); // Возвращаем доступные тесты для студентов
        }

        public static int GetTotalTestsCount()
        {
            return tests.Count; // Вернуть количество тестов
        }

        // Статистические методы
        public static int GetTotalTestPasses()
        {
            return totalTestPasses; // Получение количества успешных прохождений
        }

        public static int GetTotalTestFails()
        {
            return totalTestFails; // Получение количества неуспешных прохождений
        }

        public static void AddSuccessfulTest()
        {
            totalTestPasses++; // Увеличение счетчика успешных тестов
            SaveStatisticsToFile(); // Сохраняем статистику
        }

        public static void AddFailedTest()
        {
            totalTestFails++; // Увеличение счетчика неуспешных тестов
            SaveStatisticsToFile(); // Сохраняем статистику
        }

        private static void SaveTestsToFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(tests, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении тестов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadTestsFromFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    tests = JsonConvert.DeserializeObject<List<Test>>(json) ?? new List<Test>();
                    nextId = tests.Count > 0 ? tests.Max(t => t.Id) + 1 : 1; // Устанавливаем следующий ID
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Ошибка при загрузке тестов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void SaveStatisticsToFile()
        {
            var stats = new { TotalPasses = totalTestPasses, TotalFails = totalTestFails };
            try
            {
                string json = JsonConvert.SerializeObject(stats, Formatting.Indented);
                File.WriteAllText(statsFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении статистики: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadStatisticsFromFile()
        {
            if (File.Exists(statsFilePath))
            {
                try
                {
                    string json = File.ReadAllText(statsFilePath);
                    var stats = JsonConvert.DeserializeObject<StatisticsData>(json);
                    totalTestPasses = stats.TotalPasses;
                    totalTestFails = stats.TotalFails;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке статистики: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private class StatisticsData
        {
            public int TotalPasses { get; set; }
            public int TotalFails { get; set; }
        }
    }
}
