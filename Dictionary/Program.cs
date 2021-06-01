using System;
using System.Collections.Generic;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("txt", "notepad.exe");
            myDictionary.Add("bmp", "paint.exe");
            myDictionary.Add("dib", "paint.exe");
            myDictionary.Add("rtf", "wordpad.exe");
            if (myDictionary.ContainsKey("rtf"))
            {
                Console.WriteLine("An element with Key = \"rtf\" already exists.");
            }
            else
            {
                myDictionary.Add("rtf", "wordpad.exe");
            }
            Console.WriteLine("For key = \"rtf\", value = {0}.", myDictionary["rtf"]);
            myDictionary["rtf"] = "winword.exe";                //The indexer can be used to change the value associated with a key.
            Console.WriteLine("For key = \"rtf\", value = {0}.", myDictionary["rtf"]);
            myDictionary["doc"] = "text.exe";                //If a key does not exist, setting the indexer for that key
                                                             // adds a new key/value pair.
            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", myDictionary["tif"]);  //throws error if key is not found.
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }
            string value = "";
            if (myDictionary.TryGetValue("tif", out value))         //TryGetValue can be a more efficient way to retrieve values.
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
            ICollection<string> coll = myDictionary.Values;            // To get the values alone, use the Values property.
            Console.WriteLine();
            foreach (string s in coll)
            {
                Console.WriteLine("Value = {0}", s);
            }
            coll = myDictionary.Keys;                  // To get the keys alone, use the Keys property.
            Console.WriteLine();
            foreach (string s in coll)
            {
                Console.WriteLine("Key = {0}", s);
            }
            Console.WriteLine("\nRemove(\"doc\")");             // Use the Remove method to remove a key/value pair.
            myDictionary.Remove("doc");
            if (!myDictionary.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }
        }
    }
}
