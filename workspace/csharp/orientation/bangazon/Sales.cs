using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
public class Sales: Department
    {
        private Dictionary<string, string> SalesRules = new Dictionary<string, string>();

        public Sales(string dept_name, string supervisor, int employees): base(dept_name, supervisor, employees)
        {
        }

        public void AddPolicy(string title, string text)
        {
            SalesRules.Add(title, text);

            Console.WriteLine($"Sales Rules:");
            foreach(KeyValuePair<string, string> rules in SalesRules)
            {
                Console.WriteLine($"{rules.Key}: {rules.Value}");
            }

        }
        // Overriding the default toString() method for each object instance
        public string toString()
        {
            return $"{_name} {_supervisor} {_employee_count}";
        }
    }
}