﻿using System;
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
        }
    }
}
