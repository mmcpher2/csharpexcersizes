using System;
using System.Collections.Generic;

namespace classes
{
    class CurrentEmployees
    {

    }
    public class Company
{
    /*
        Some readonly properties
    */
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a property for holding a list of current employees
    public List<CurrentEmployees> currentEmployees { get; set; }
    // Create a method that allows external code to add an employee

    // Create a method that allows external code to remove an employee

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
}
}
