using System;
using System.Collections.Generic;

namespace GCUniversity.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
