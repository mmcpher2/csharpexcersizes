using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
public class HumanResources: Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public HumanResources(string name, string supervisor, int employees, double baseBudget, double setBudget): base(name, supervisor, employees, baseBudget, setBudget)
        {
        }

        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            Console.WriteLine($"HR Policies:");
            foreach(KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }

        }
        // Overriding the default toString() method for each object instance
        public string toString()
        {
            return $"{_name} {_supervisor} {_employee_count}";
        }
    }
}