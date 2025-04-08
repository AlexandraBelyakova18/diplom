using System.Collections.Generic;
using System.Linq; // Необходим для использования метода Average

namespace OnlineLearningSystem.Models
{
    public class TestResults
    {
        public int UserId { get; set; }  // Идентификатор пользователя
        public int TestId { get; set; }  // Идентификатор теста
        public bool IsPassed { get; set; }  // Статус прохождения теста
        public double Score { get; set; }  // Оценка на тесте

        // Конструктор с параметрами
        public TestResults(int userId, int testId, bool isPassed, double score)
        {
            UserId = userId;
            TestId = testId;
            IsPassed = isPassed;
            Score = score;
        }

        // Конструктор по умолчанию
        public TestResults()
        {
        }

        // Метод для получения среднего значения
        public static double GetAverageScore(List<TestResults> results)
        {
            if (results == null || results.Count == 0) return 0;
            return results.Average(r => r.Score); // Использование метода Average из System.Linq
        }
    }
}
