using System;
using System.Collections.Generic;

namespace GCUniversity.Models
{
    public partial class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int AdminId { get; set; }
        public string Semester { get; set; }
        public string FinalGrade { get; set; }

        public virtual Administrator Admin { get; set; }
        public virtual Courses Course { get; set; }
        public virtual Students Student { get; set; }
    }
}
