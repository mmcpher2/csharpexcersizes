using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {


        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Mitsubishi Lancer");
            Showroom.Add("Jeep Compass");
            Showroom.Add("Acura Integra");
            Showroom.Add("Lexus LS");

            Showroom.Add("Mitsubishi Lancer");
            Console.WriteLine("Showroom Count: {0}\n", Showroom.Count);

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Ford Titan");
            UsedLot.Add("Nissan F150");

            // combine the showroom and the used lot
            Showroom.UnionWith(UsedLot);

            // you sold a car
            Showroom.Remove("Acura Integra");
        }
    }
}