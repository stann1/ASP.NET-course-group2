using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcBasics.Controllers
{
    public class StudentsController : Controller
    {
        Dictionary<int, Student> studentsDict;

        public StudentsController()
        {
            this.studentsDict = new Dictionary<int, Student>();
            studentsDict[1] = new Student() { FirstName = "Ivan", LastName = "Ivanov", Age = 23 };
            studentsDict[2] = new Student() { FirstName = "Georgi", LastName = "Petrov", Age = 23 };
        }

        public IActionResult Index()
        {
            var students = new List<Student>();
            foreach (var item in studentsDict)
            {
                students.Add(item.Value);
            }
            return View("IndexStudents", students);
        }

        public IActionResult ById(int id)
        {
            return View(model: studentsDict[id]);
        }
    }
}