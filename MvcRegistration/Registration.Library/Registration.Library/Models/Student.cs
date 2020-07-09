﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Library.Models
{
    public class Student
    {
        private string _firstName;
        private string _lastName;

        public int Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("First Name cannot be empty", nameof(value));
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name cannot be empty", nameof(value));
                }
                _lastName = value;
            }
        }
    }
}
