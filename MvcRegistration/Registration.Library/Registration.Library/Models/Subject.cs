using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Library.Models
{
    public class Subject
    {
        private string _subjectName;
        private string _teacher;

        public int Id { get; set; }

        public string SubjectName
        {
            get => _subjectName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Subject Name cannot be empty", nameof(value));
                }
                _subjectName = value;
            }
        }

        public string Teacher
        {
            get => _teacher;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Teacher cannot be empty", nameof(value));
                }
                _teacher = value;
            }
        }
    }
}
