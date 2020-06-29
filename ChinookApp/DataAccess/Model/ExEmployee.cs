﻿using System;
using System.Collections.Generic;

namespace DataAccess.Model
{
    public partial class ExEmployee
    {
        public ExEmployee()
        {
            EmpDetails = new HashSet<EmpDetails>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Ssn { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<EmpDetails> EmpDetails { get; set; }

        public static implicit operator ExEmployee(ExEmployee v)
        {
            throw new NotImplementedException();
        }
    }
}
