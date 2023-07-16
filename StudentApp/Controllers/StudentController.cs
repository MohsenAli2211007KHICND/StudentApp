using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentApp.Models;
using System.Net;

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("all", Name = "GetStudents")]
        public IEnumerable<Student> GetStudents()
        {
            return StudentRepository.Students;
        }

        [HttpGet("{id:int}", Name = "GetStudentById")]
        public Student GetStudentById(int id)
        {
            return StudentRepository.Students.FirstOrDefault(x => x.Id == id);
        }

        [HttpGet]
        [Route("{name}", Name = "GetStudentByName")]
        public Student GetStudentByName (string name)
        {
            return StudentRepository.Students.FirstOrDefault(u => u.StudentName == name);
        }

        [HttpDelete]
        [Route("{id}", Name = "DeleteStudent")]
        public bool DeleteStudent(int id)
        {
            var student = StudentRepository.Students.FirstOrDefault(u => u.Id == id);
            if (student != null)
            {
                StudentRepository.Students.Remove(student);
            }
            return true;
        }
    }
}
