using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(8);
            lst.Add(45);
            lst.Add(47);
            lst.Add(49);
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List1 Elements Count: " + lst.Count);
            Console.WriteLine("List1 Capacity: " + lst.Capacity);
            string[] cities = new string[3] { "Mumbai", "London", "New York" };
            List<string> popularCities = new List<string>();
            popularCities.AddRange(cities);                                             // adding an array in a List
            popularCities.Insert(0, "Hyderabad");                                       //inserting elements into list
            foreach (string s in popularCities)
                Console.Write(s + " ");
            Console.WriteLine();
            popularCities.Remove("London");                                            // Removing an element from list
            foreach (string s in popularCities)
                Console.Write(s + " ");
            Console.WriteLine();
            lst.RemoveAt(2);                                                           // Removing an element at index 2
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
            lst.RemoveRange(1, 2);                                             // Removing 2 elements starting from index 1
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
