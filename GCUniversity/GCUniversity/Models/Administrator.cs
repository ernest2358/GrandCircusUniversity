using System;
using System.Collections.Generic;

namespace GCUniversity.Models
{
    public partial class Administrator
    {
        public Administrator()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
