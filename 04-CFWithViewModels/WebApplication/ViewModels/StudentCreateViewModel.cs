using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class StudentCreateViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Range(1,100)]
        public int Age { get; set; }

        public Student MapToDbModel()
        {
            return new Student()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                EnrolledOn = DateTime.Now.ToShortDateString()
            };
        }
    }
}
