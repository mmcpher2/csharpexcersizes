using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
public class Operations: Department
    {
        private Dictionary<string, string> OperationsRules = new Dictionary<string, string>();

        public Operations(string dept_name, string supervisor, int employees): base(dept_name, supervisor, employees)
        {
        }

        public void AddPolicy(string title, string text)
        {
            OperationsRules.Add(title, text);

            Console.WriteLine($"Ops Rules:");
            foreach(KeyValuePair<string, string> rule in OperationsRules)
            {
                Console.WriteLine($"{rule.Key}: {rule.Value}");
            }
        }
        // Overriding the default toString() method for each object instance
        public string toString()
        {
            return $"{_name} {_supervisor} {_employee_count}";
        }
    }
}