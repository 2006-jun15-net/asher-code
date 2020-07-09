using System;
using System.Collections.Generic;

namespace Registration.DataAccess.Entities
{
    public partial class Score
    {
        public int ScoreId { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public int Marks { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
