using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
public class Sales: Department
    {
        private Dictionary<string, string> SalesRules = new Dictionary<string, string>();

        public Sales(string name, string supervisor, int employees): base(name, supervisor, employees)
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
        public override void setBudget(double budget)
        {
            this.Budget += budget + 100000.00;
            Console.WriteLine($"Sales Budget: ${Budget}");
        }
    }
}