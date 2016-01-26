using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a couple of instances of the Employee class
            Employee employee1 = new Employee("Dave", "Barnes", 537.00m);
            Employee employee2 = new Employee("Joe", "Somebody", 125.50m);

            //Creat simple int that will be used for value vs reference
            int myNumber = 5;

            //Write the value of the int before the method, call the method, print after call.
            Console.WriteLine(myNumber);
            changeAnInt(myNumber);
            Console.WriteLine(myNumber);

            //Write the value of the employee before the method, call the method, print after call.
            Console.WriteLine(employee1.ToString());
            changeAnObject(employee1);
            Console.WriteLine(employee1.ToString());
            
            //Console.WriteLine(employee.GetFullName());
            //Console.WriteLine(employee.ToString());

            //Showing how to use an array with objects
            Employee[] employees = new Employee[10];

            //Instanciate some employees into the array
            employees[0] = new Employee("James", "Kirk", 453.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 290.00m);
            employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 194.00m);
            employees[4] = new Employee("Johnathan", "Archer", 394.00m);

            //A for each loop that will loop through each element of the employees array
            foreach (Employee employee in employees)
            {
                //Check to make sure that the current object is not null.
                //we know that the first 5 have values because we assigned them right above
                //but the last 5 are null, so we better put in a check.
                if (employee != null)
                {
                    //output the information of the employee
                    Console.WriteLine(employee.ToString());
                }
            }

            //We are creating a new UserInterface class, and it's okay
            //that the UserInterface class does not have a defined
            //constructor. It will have a default one provide to us that
            //we can take advantage of by just not passing in any parameters
            UserInterface ui = new UserInterface();

            //Call the GetUserInput method of the UI class. It will return
            //a valid integer that represents the choice they want to do.
            int choice = ui.GetUserInput();

            //While the choice is not the exit choice (which in this case is 2)
            while (choice != 2)
            {
                //If the choice is 1, which in this case it has to be, but if there
                //were more menu options it might not be so obvious.
                if (choice == 1)
                {
                    //Create a empty string to concat to.
                    string allOutput = "";
                    //For each Employee in the employees array.
                    foreach (Employee employee in employees)
                    {
                        //So long as the spot in the array is not null
                        if (employee != null)
                        {
                            //Concat the employee changed to a string plus a new line
                            //to the allOutput string.
                            allOutput += employee.ToString() + Environment.NewLine;
                        }
                    }
                    //Now that the large string containing what I would like to output
                    //is created, I can output it to the screen using the
                    //PrintAllOutput method of the UI class.
                    ui.PrintAllOutput(allOutput);
                }

                //Now that the "Work" that we wanted to do is done,
                //We need to re-prompt the user for some input
                choice = ui.GetUserInput();
            }





        }

        //This method takes in a integer, which is passed by value
        //and then changes the value of it.
        static void changeAnInt(int myNumber)
        {
            myNumber = 456;
        }

        //This method takes in a Employee class, which is passed by reference
        //and then changes a property of it.
        static void changeAnObject(Employee employee)
        {
            employee.FirstName = "Thor";
        }



    }
}
