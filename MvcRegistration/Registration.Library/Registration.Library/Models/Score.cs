using System;

namespace Registration.Library.Models
{
    public class Score
    {
        private int _marks;

        public int Id { get; set; }

        public int Marks
        {
            get => _marks;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Marks have to be between 0 and 100", nameof(value));
                }
                _marks = value;
            }
        }

        public int? StudentId { get; set; }

        public int? SubjectId { get; set; }
    }
}
