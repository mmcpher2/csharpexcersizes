﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class Department
    {
        public string _name;
        public string _supervisor;
        public int _employee_count;
        public string _location;

        // Constructor method
        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }
    }
}