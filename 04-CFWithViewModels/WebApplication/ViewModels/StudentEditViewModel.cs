using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class StudentEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }

        public string Notes { get; set; }

        public Student MapToDbModel()
        {
            return new Student()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                TeacherNotes = this.Notes
            };
        }

        public static StudentEditViewModel MapFromDbModel(Student model)
        {
            return new StudentEditViewModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Notes = model.TeacherNotes
            };
        }
    }
}
