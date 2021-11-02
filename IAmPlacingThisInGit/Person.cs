using System;
using System.Collections.Generic;
using System.Text;

namespace IAmPlacingThisInGit
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(int age, string name, string email)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }
    }
}
