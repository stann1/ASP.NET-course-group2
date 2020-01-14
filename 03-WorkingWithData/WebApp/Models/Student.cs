using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
