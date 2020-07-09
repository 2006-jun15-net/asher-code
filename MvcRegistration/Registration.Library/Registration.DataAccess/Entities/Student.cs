using System;
using System.Collections.Generic;

namespace Registration.DataAccess.Entities
{
    public partial class Student
    {
        public Student()
        {
            Score = new HashSet<Score>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Score> Score { get; set; }
    }
}
