using StudentApp.Models;

namespace StudentApp
{
    public static class StudentRepository
    {
        public static List<Student> Students { get; set; } = new List<Student> { new Student
            {
                Id = 1,
                StudentName = "Mohsen Ali",
                Email = "mohsenali@work.com",
                Address = "Buleda, Turbat, Balochistan",
                Age = 23
            },
             new Student{
                Id = 2,
                StudentName = "Faiz Gul",
                Email = "faizgul@work.com",
                Address = "Buleda, Turbat, Balochistan",
                Age = 24
            }
            };
    }
}
