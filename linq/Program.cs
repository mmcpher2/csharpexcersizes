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

            
        }
    }
}
