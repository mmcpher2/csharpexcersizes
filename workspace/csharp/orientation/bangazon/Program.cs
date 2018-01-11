using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class Department
    {
        public string _name;
        public string _supervisor;
        public int _employee_count;
        public double _baseBudget { get; set; }
        public double _setBudget { get; set; }

        // Constructor method
        public Department(string name, string supervisor, int employees, double baseBudget, double setBudget)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
            _baseBudget = baseBudget;
            _setBudget = setBudget;
        }

        // public virtual double setBudget(double baseBudget);

    }
}
