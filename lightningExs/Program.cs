using System;
using System.Linq;
using System.Collections.Generic;

namespace lightningExs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> dictionaryOne = new Dictionary<string, double>();
            Dictionary<string, List<int []>> dictionaryTwo = new Dictionary<string, List<int[]>>();
            List<Dictionary<string, Dictionary<int, string>>> dictionaryThree = new List<Dictionary<string, Dictionary<int, string>>>();

            List<int> numbers = new List<int>(){ 23, 45, 36, 39, 102, 493, 474, 34, 11, 35, 99 };
            // Using Linq...
            // 1. Find the sum of numbers
                numbers.Sum();
            // 2. Find the average of the numbers
                numbers.Average();
            // 3. Create a new List of numbers greater than 30
                List<int> greater = numbers.Where(num => num >30).ToList();
            }
        }
    }
