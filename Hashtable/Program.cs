using System;
using System.Collections;

namespace Generic_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", ".Net");
            ht.Add("2", "C#");
            ht.Add("3", "ASP.Net");
            ICollection keys = ht.Keys;
            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }
            Console.ReadKey();
        }
    }
}
