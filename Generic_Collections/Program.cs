using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listObj = new List<int>();                                    //List
            listObj.Add(123);
            listObj.Add(235);
            Console.WriteLine("list values");
            foreach (int z in listObj)
            {
                Console.WriteLine(z);
            }

            Dictionary<int, string> objDic = new Dictionary<int, string>();         //Dictionary
            objDic.Add(123, "Rohit");
            Console.WriteLine("Dictionary Value: {0}", objDic[123]);                //Dictionary value using Key  

            Stack<int> objStack = new Stack<int>();                                 //Stack
            objStack.Push(1);                                                       //Inserts an item at the top of the stack.
            objStack.Push(2);
            objStack.Push(3);
            Console.WriteLine("Value from Stack: {0}", objStack.Pop());   //Removes and returns items from the top of the stack.

            Queue<int> objQueue = new Queue<int>();                                 //Queue
            objQueue.Enqueue(1);                                                    //Adds an item into the queue.
            objQueue.Enqueue(2);
            objQueue.Enqueue(3);
            Console.WriteLine("Value from Queue: {0}", objQueue.Dequeue());   //Returns an item from the beginning of the queue and removes it from the queue.
            Console.WriteLine();
        }
    }
}
