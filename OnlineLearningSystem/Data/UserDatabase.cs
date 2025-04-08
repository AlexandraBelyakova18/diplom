using System.Collections.Generic;
using OnlineLearningSystem.Models;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace OnlineLearningSystem.Data
{
    public static class UserDatabase
    {
        private static List<User> users = new List<User>();
        private static int nextId = 1;
        private static readonly string filePath = "users.json"; // Путь к файлу хранения

        static UserDatabase()
        {
            LoadUsersFromFile(); // Загружаем пользователей из файла при запуске
            if (users.Count == 0)
            {
                // Начальные данные, если файл не найден или пуст
                users.Add(new User(nextId++, "Admin", "admin123", "Администратор", 2)); // Уровень знаний для администратора
                users.Add(new User(nextId++, "Teacher1", "teacher123", "Преподаватель", 1)); // Уровень знаний для преподавателя
                users.Add(new User(nextId++, "Student1", "student123", "Студент", 0)); // Уровень знаний для студента
                SaveUsersToFile(); // Сохраняем начальные данные
            }
        }

        public static User ValidateUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public static void RegisterUser(User user)
        {
            if (users.Any(u => u.Username == user.Username))
            {
                throw new System.Exception("Пользователь с таким именем уже существует.");
            }

            user.Id = nextId++;
            users.Add(user);
            SaveUsersToFile(); // Сохраняем изменения в файл
        }

        private static void SaveUsersToFile()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private static void LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json);
                nextId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1; // Устанавливаем следующий ID
            }
        }

        public static List<User> GetUsers()
        {
            return users;
        }

        public static User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
    }
}
