using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using OnlineLearningSystem.Models;

namespace OnlineLearningSystem.Data
{
    public static class CourseManager
    {
        private static readonly string filePath = "courses.json"; // Путь к файлу для хранения курсов
        private static List<Course> courses;

        static CourseManager()
        {
            LoadCourses(); // Загружаем курсы при инициализации класса
        }

        public static void AddCourse(Course course)
        {
            course.Id = courses.Count > 0 ? courses[courses.Count - 1].Id + 1 : 1; // Присваиваем новый Id
            courses.Add(course);
            SaveCourses(); // Сохраняем курсы после добавления
        }

        public static List<Course> GetCoursesForStudents()
        {
            return courses.Where(course => course.IsAvailableForStudents).ToList(); // Возвращаем курсы для студентов
        }

        public static void SaveCourses()
        {
            var json = JsonConvert.SerializeObject(courses, Formatting.Indented);
            File.WriteAllText(filePath, json); // Сохраняем курсы в файл
        }

        public static void LoadCourses()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);

                courses = JsonConvert.DeserializeObject<List<Course>>(json) ?? new List<Course>();
            }
            else
            {
                courses = new List<Course>(); // Если файла нет, создаем новый список
            }
        }

        public static List<Course> GetCourses()
        {
            return courses; // Возвращаем список курсов
        }
    }
}
