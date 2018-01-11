using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class Program
    {
        public static void Main() {
            List<Department> departments = new List<Department>();


            // Create some instances
            HumanResources hr = new HumanResources("HR", "Amy Schumer", 2);
            hr.AddPolicy("Don't burp!", "Please don't do that in the office");

            Sales sales = new Sales("Sales", "Ryan McPherson", 195);
            sales.AddPolicy("Sell no matter what.", "Do anything you have to do.");

            Operations operations = new Operations("Operations", "Don Young", 2345);
            operations.AddPolicy("Build things that dont break.", "It's your job.");

            // Add derived departments to the list
            departments.Add(hr);
            departments.Add(sales);
            departments.Add(operations);
            
            // Iterate over all items in the list and output a string
            // representation of the class
            foreach(Department d in departments)
            {
                Console.WriteLine($"Department: {d._name}, Supervisor: {d._supervisor}, Employee Count: {d._employee_count}");
            }
        }
    }
}