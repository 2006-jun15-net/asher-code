using System;
using System.Collections.Generic;

namespace DataAccess.Model
{
    public partial class Department
    {
        public Department()
        {
            ExEmployee = new HashSet<ExEmployee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<ExEmployee> ExEmployee { get; set; }
    }
}
