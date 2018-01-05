using System;
using System.Linq;
using System.Collections.Generic;

// Just a label
namespace lists
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> planetList = new List<string>()
            {"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>()
            {"Uranus", "Neptune"};

            planetList.AddRange(lastTwoPlanets);

            // Insert Venus and Earth to the beginning of the list
            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            // Add Pluto to the end of the list
            planetList.Add("Pluto");
            // List only the rocky planets
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            // Remove Pluto from the list
            planetList.Remove("Pluto");

            List<Dictionary<string, List<string>>> spacecraft = new List<Dictionary<string, List<string>>>();

            // Create MarsCraft
            string marsCraft = "Mars 1960A";
            List<string> marsCraftDestinations = new List<string>(){
                "Mars", "Saturn"
            };
            Dictionary<string, List<string>> mars1960Dict = new Dictionary<string, List<string>>();
            mars1960Dict.Add(marsCraft, marsCraftDestinations);

            // Create MarsCraft
            string voyager2Craft = "Voyager2";
            List<string> voyager2Destinations = new List<string>(){
                "Jupiter", "Saturn", "Uranus", "Neptune", "Mars"
            };
            Dictionary<string, List<string>> voyager2Dict = new Dictionary<string, List<string>>();
            voyager2Dict.Add(voyager2Craft, voyager2Destinations);

            spacecraft.Add(mars1960Dict);
            spacecraft.Add(voyager2Dict);

            // Write the list to the console (terminal)
            foreach(string planets in planetList) {

                string doublePlanet = $"{planets}:" + " ";

                foreach(Dictionary<string,List<string>> listOfDictionaries in spacecraft) {

                    foreach(KeyValuePair<string, List<string>> kvp in listOfDictionaries) {

                        foreach(string planetsSeen in kvp.Value){
                            if (planetsSeen == planets) {
                                doublePlanet += kvp.Key + ", ";
                                }
                            }
                        }
                    }
                    if(doublePlanet.EndsWith(": ") != true) {
                        char[] charsToTrim = {',', ' '};
                        Console.WriteLine(doublePlanet.TrimEnd(charsToTrim));
                    }
                }
            }
        }
    }

