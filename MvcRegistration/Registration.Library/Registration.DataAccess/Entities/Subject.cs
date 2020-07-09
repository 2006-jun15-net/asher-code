using System;
using System.Collections.Generic;

namespace Registration.DataAccess.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            Score = new HashSet<Score>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Teacher { get; set; }

        public virtual ICollection<Score> Score { get; set; }
    }
}
