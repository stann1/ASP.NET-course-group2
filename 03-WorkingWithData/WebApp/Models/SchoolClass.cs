using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
