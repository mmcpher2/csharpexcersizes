using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
public class Employee
    {

        public string FirstName {get; set;}
        public string LastName {get; set;}

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public List<string> restaurantList = new List<string>()
        {
            "Las Palmas",
            "Taco Bell",
            "Otaku Ramen",
            "Pizza Hut",
            "Don Juans"
        };

        public string eat()
        {
            Random randomizer = new Random();
            int restaurantNumber = randomizer.Next(0,5);
            string restarauntLocation = "";
            foreach(string restaurant in restaurantList){
                int listIndex = restaurantList.FindIndex(i => i == restaurant);
                if (restaurantNumber == listIndex) {
                    Console.WriteLine($"{this.FirstName} is eating lunch at {restaurant}");
                    restarauntLocation = restaurant;
                }
            }
            return restarauntLocation;
        }
    }
}
