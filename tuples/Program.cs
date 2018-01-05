using System;
using System.Linq;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            (string product, double amount, int quantity) productSaw = ("Saw", 10.99, 1);
            (string product, double amount, int quantity) productClock = ("Clock", 20.99, 3);
            (string product, double amount, int quantity) productNail = ("Nail", 2.99, 4);
            (string product, double amount, int quantity) productTape = ("Tape", 10.79, 2);
            (string product, double amount, int quantity) productTree = ("Tree", 3.99, 9);

            transactions.Add(productSaw);
            transactions.Add(productClock);
            transactions.Add(productNail);
            transactions.Add(productTape);
            transactions.Add(productTree);

        int totalSoldItems = 0;
        double totalRevenue = 0;

        foreach ((string product, double amount, int quantity) t in transactions)
        {
            totalSoldItems += t.quantity;
            totalRevenue += t.amount;

            // Logic goes here to look up quantity and amount in each transaction
        }
            Console.WriteLine("Items Sold Today: " + totalSoldItems);
            Console.WriteLine("Total Revenue: " + totalRevenue);
        }
    }
}
