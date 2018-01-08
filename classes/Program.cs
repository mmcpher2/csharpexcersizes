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

                public void addEmployee (Employee employee)
                    {
                        currentEmployees.Add(employee);
                    }
                // Create a method that allows external code to remove an employee
                public void removeEmployee (Employee employee)
                    {
                        currentEmployees.Remove(employee);
                    }
                    /*
                        Create a constructor method that accepts two arguments:
                            1. The name of the company
                            2. The date it was created

                        The constructor will set the value of the public properties
                    */
                public Company (String Name, DateTime CreateOn) {
                    this.Name = Name;
                    this.CreatedOn = new DateTime();
                    this.currentEmployees = new List<Employee>();
                    }
            }

    public static void Main(string[] args)
        {
            Employee Ryan = new Employee();
            Ryan.Name = "Ryan";
            Ryan.Title = "President";
            Ryan.CreatedOn = new DateTime();

            Employee Dave = new Employee();
            Dave.Name = "Dave";
            Dave.Title = "Vice President";
            Dave.CreatedOn = new DateTime();

            Employee Todd = new Employee();
            Todd.Name = "Todd";
            Todd.Title = "Janitor";
            Todd.CreatedOn = new DateTime();

            // Add employee to a List of employees
            List<Employee> currentEmployees = new List<Employee>();
            currentEmployees.Add(Ryan);
            currentEmployees.Add(Dave);
            currentEmployees.Add(Todd);

            Company Apple = new Company("Apple", DateTime.Now);
            Apple.addEmployee(Ryan);
            Apple.addEmployee(Dave);
            Apple.addEmployee(Todd);

            foreach(Employee name in currentEmployees) {
                Console.WriteLine($"{name.Name}: '{name.Title}' = Started On: {name.CreatedOn}");
            }
        }
    }
}