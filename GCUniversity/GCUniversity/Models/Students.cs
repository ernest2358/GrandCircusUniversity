using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GCUniversity.Models
{
    public partial class Students
    {
        public Students()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
