using System;

namespace OnlineLearningSystem.Models
{
    public class User
    {
        public int Id { get; set; }              // Идентификатор пользователя
        public string Username { get; set; }      // Имя пользователя
        public string Password { get; set; }      // Пароль
        public string Role { get; set; }          // Роль пользователя
        public int KnowledgeLevel { get; set; }   // Уровень знаний пользователя

        // Конструктор с параметрами
        public User(int id, string username, string password, string role, int knowledgeLevel)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
            KnowledgeLevel = knowledgeLevel;
        }

        // Конструктор по умолчанию
        public User()
        {
            KnowledgeLevel = 0; // Установить уровень знаний по умолчанию
        }

        // Метод для обновления уровня знаний на основе результатов тестов
        public void UpdateKnowledgeLevel(TestResults results)
        {
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results), "Results cannot be null.");
            }

            // Логика для определения уровня знаний на основе статуса и оценки
            if (results.IsPassed)
            {
                // Можно добавить дополнительную логику для вычисления оценки
                // Пример: если у вас есть средний балл, его можно учитывать
                KnowledgeLevel = 3; // Уровень знаний по умолчанию, если результат положительный
            }
            else
            {
                KnowledgeLevel = 1; // Базовый уровень, если результат не пройден
            }
        }
    }
}
