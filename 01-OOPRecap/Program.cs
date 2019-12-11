using System;
using System.Collections.Generic;
using System.Linq;

namespace aspnetcore_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 - 1.4
            var student1 = new Student("Ivan", "Ivanov", 23);
            var student2 = new Student("Georgi", "Ivanov", 33);
            var student3 = new Student("Pesho", "Peshev", 16);

            var students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            foreach (var student in students)
            {
                System.Console.WriteLine(student.FullName);
            }

            // 1.5 option 1
            // Func<Student,int> delFunction = (s) => {return s.Age;};
            // var sortedList = students.OrderBy(delFunction);
            
            // 1.5 option 2
            var sortedList = students.OrderBy((s) => s.Age);
            var selected = students.Where(s => s.Age > 18);
            
            foreach (var student in sortedList)
            {
                System.Console.WriteLine(student.FullName);
            }

            // extensions demo
            string studentAddress = "ul. Nova Gora 6";
            System.Console.WriteLine($"The text contains {studentAddress.GetWordCount()} words");

            // anonymous types demo
            var anonymousPerson = new {name = "Nik", age = 6};
            System.Console.WriteLine($"{anonymousPerson.name} --> {anonymousPerson.age}");
        }
    }
}
