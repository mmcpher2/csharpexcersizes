using System;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Kathleen"},
                {"age", "23"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Cameron"},
                {"age", "30"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Mike"},
                {"age", "59"}
            });
            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Lisa"},
                {"age", "57"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily) {
                string familyMemberType = familyMember.Key;

                var eachFamilyMember = familyMember.Value;
                foreach(KeyValuePair<string, string> nameAndAge in eachFamilyMember){
                    Console.WriteLine("");
                    if (nameAndAge.Key == "name"){
                        string personName = nameAndAge.Value;
                        Console.Write($"{personName} is my {familyMemberType} and is ");
                    } else {
                        string personAge = nameAndAge.Value;
                        Console.Write($"{personAge} years old.");
                    }
                }
            }
        }
    }
}
