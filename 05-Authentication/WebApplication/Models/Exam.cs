using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public partial class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public int StudentId { get; set; }
    }
}
