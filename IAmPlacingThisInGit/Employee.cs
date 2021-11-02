using System;
using System.Collections.Generic;
using System.Text;

namespace IAmPlacingThisInGit
{
    class Employee : Person
    {
        public int EmployeeID { get; set; }

        public Employee(int employeeID, string name, int age, string email)
            : base(name, age, email)
        {
            EmployeeID = employeeID;
        }
    }
}
