using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
        // Find the words in the collection that start with the letter 'L'
        List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

        var LFruits =
            from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

        foreach (string fruit in LFruits)
            {
            Console.WriteLine(fruit);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend =
                from name in names
                orderby name descending
                select name;

            foreach (string word in descend) {
                Console.WriteLine(word);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var ascend =
            from number in numbers
            orderby number
            select number;

            foreach (int item in ascend)
            {
                Console.WriteLine(item);
            }

            // Output how many numbers are in this list
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int totalNumbers = numbers2.Count();
            Console.WriteLine("Total numbers in Numbers2: {0}", totalNumbers);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double totalMoneys = purchases.Sum();
            Console.WriteLine("We have made a total of ${0}", totalMoneys);

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double maxPrice = prices.Max();
            Console.WriteLine("The max price is: ${0}", maxPrice);

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<double> wheresSquaredo = new List<double>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            foreach(double number in wheresSquaredo){
            Console.WriteLine(Math.Sqrt(number));
            }

            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            // list of millionaires
            List<Customer> millionaires = customers.Where(c => c.Balance >= 1000000).ToList();

            var groupsOfMillionaires =
                from customer in millionaires
                group customers by customer.Bank into milGroup
                select new {
                    Bank = milGroup.Key,
                    NumberOfMils = milGroup.Count()
                };

            foreach (var bank in groupsOfMillionaires){
                Console.WriteLine($"{bank.Bank}: {bank.NumberOfMils}");
            }
        }
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

                // Define a bank
        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }

        // Create some banks and store in a List
        List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };
    }
}


