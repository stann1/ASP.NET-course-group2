using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class TeamMember
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [RegularExpression(@"\w+@\w+\.\w+", ErrorMessage = "Not a valid email")]
        public string Email { get; set; }
    }
}
