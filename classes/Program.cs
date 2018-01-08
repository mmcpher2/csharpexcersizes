using System;
using System.Collections.Generic;

namespace classes {
    class Program {
        public class Employee
            {
                public string Name {get; set; }
                public string Title {get; set; }
                public DateTime CreatedOn {get; set; }
            }

    public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }
            // Create a property for    holding a list of current employees
            public List<Employee> currentEmployees { get; set; }
            // Create a method that allows external code to add an employee
            public void addEmployee (string Name, string Title, DateTime CreatedOn)
                {
                    currentEmployees.Add(this, Employee);
                }
            // Create a method that allows external code to remove an employee
            public void removeEmployee (string Name, string Title, DateTime CreatedOn)
                {
                    currentEmployees.Remove(this, currentEmployee);
                }
                /*
                    Create a constructor method that accepts two arguments:
                        1. The name of the company
                        2. The date it was created

                    The constructor will set the value of the public properties
                */
            public Company (String Name, DateTime CreateOn) {
                Name = "Ryans Company";
                CreatedOn = new DateTime();
                }
        }

    public static void Main(string[] args)
        {
            Company ryansCompany = new Company();

            Employee Ryan = new Employee();
            Ryan.Name = "Ryan";
            Ryan.Title = "President";
            Ryan.CreatedOn = new DateTime();

            Employee Dave = new Employee();
            Ryan.Name = "Dave";
            Ryan.Title = "Vice President";
            Ryan.CreatedOn = new DateTime();

            Employee Todd = new Employee();
            Ryan.Name = "Todd";
            Ryan.Title = "Janitor";
            Ryan.CreatedOn = new DateTime();

            // Add employee to a List of employees
            List<Employee> currentEmployees = new List<Employee>();
            currentEmployees.Add(Ryan);
            currentEmployees.Add(Dave);
            currentEmployees.Add(Todd);
        }
    }
}