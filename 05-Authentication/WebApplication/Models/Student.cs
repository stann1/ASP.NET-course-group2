using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Exam> Exams { get; set; }
    }
}
