using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        //Backing fields
        private string firstName;
        private string lastName;
        private decimal weeklySalary;

        //properties for the backing fields
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
        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        //One Method that is public. Can be accessed from other classes
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.weeklySalary.ToString("C");
        }

        //One method that is private. Can only be called from inside this class
        private string foo()
        {
            return "FOO";
        }

        //3 Parameter constructor
        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            //Assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;

            //Assign the passed in value by the property
            this.WeeklySalary = weeklySalary;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank
        }
    }
}
