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
            Console.WriteLine("Showroom Count: {0}", Showroom.Count);

            // current cars in showroom
            Console.WriteLine("First showroom: ");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Ford Titan");
            UsedLot.Add("Nissan F150");

            // combine the showroom and the used lot
            Showroom.UnionWith(UsedLot);
            // current cars in showroom
            Console.WriteLine("Second showroom: ");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }
            // you sold a car
            Showroom.Remove("Acura Integra");
            // current cars in showroom
            Console.WriteLine("Third showroom, with Acura taken out: ");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }
            // cars in junkyard
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Nissan Pathfinder");
            Junkyard.Add("Dodge Charger");
            Junkyard.Add("Acura Integra");
            Junkyard.Add("Toyota Supra");

            // which cars exist in showroom and junkyard
            Showroom.IntersectWith(Junkyard);

            // Buying the cars in the junkyard, Combing the junkyard and showroom
            Showroom.UnionWith(Junkyard);
            // current cars in showroom
            Console.WriteLine("Fourth showroom, with junkyard: ");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            // Remove cars aquired from Junkyard that we dont want in the showroom
            Junkyard.Remove("Acura Integra");
            // current cars in showroom
            Console.WriteLine("Fourth showroom, without Acura: ");
            foreach(string car in Junkyard){
                Console.WriteLine(car);
            }
        }
    }
}