using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z.-_0\-9]+@[a-zA-Z.-0\-9]+\.[a-zA-Z]{2,}")]
        public string Email { get; set; }

        [Required]
        [Range(1, 150)]
        public int Age { get; set; }

        public int? SchoolClassId { get; set; }
    }
}
