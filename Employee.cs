using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBManufacturing
{
    [Serializable]  // permission to be written to file
    public class Employee
    {
        // attributes
        protected string employeeID;
        protected string firstName;
        protected string lastName;

        // constructors
        public Employee()
        {
            FirstName = "N/A";
            LastName = "N/A";
            EmployeeID = "N/A";
        }

        public Employee(string employeeID, string firstName, string lastName)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName= lastName;
        }

        // properties
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }        

        // behaviors
        public override string ToString()
        {
            return "Employee ID: " + employeeID + ", Name: " + firstName + " " + lastName;
        }
    }
}
