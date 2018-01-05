using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("HSTM", "HealthStream");
            stocks.Add("HCA", "HealthCare Corporation of America");
            stocks.Add("AAPL", "Apple");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 20, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 120, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 10, price: 45));
            purchases.Add((ticker: "CAT", shares: 20, price: 13));
            purchases.Add((ticker: "HCA", shares: 300, price: 90.02));
            purchases.Add((ticker: "AAPL", shares: 70, price: 24));
            purchases.Add((ticker: "AAPL", shares: 10, price: 12.24));
            purchases.Add((ticker: "HSTM", shares: 2, price: 19.02));

            // Define a new Dictionary to hold the aggregated purchase information.
            // - The key should be a string that is the full company name.
            // - The value will be the valuation of each stock (price*amount)
            Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases){
                double stockPurchaseValue = purchase.price * purchase.shares;
                // Does the company name key already exist in the report dictionary?
                foreach(KeyValuePair<string, string> stockFullNames in stocks)
                    // If it does, update the total valuation
                    if (purchase.Item1 == stockFullNames.Key) {
                        if (purchaseInfo.ContainsKey(stockFullNames.Value) == false){
                            purchaseInfo.Add(stockFullNames.Value, stockPurchaseValue);
                            } else {
                                purchaseInfo[stockFullNames.Value] += stockPurchaseValue;
                            }
                        }
                    // If not, add the new key and set its value
                    }
                foreach(KeyValuePair<string, double> stockInfo in purchaseInfo) {
                    Console.WriteLine($"{stockInfo.Key}" + ": " + $"${stockInfo.Value}");
                }
            }
        }
    }

