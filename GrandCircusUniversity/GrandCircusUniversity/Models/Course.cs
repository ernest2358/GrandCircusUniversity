using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrandCircusUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}