﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IAmPlacingThisInGit
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
