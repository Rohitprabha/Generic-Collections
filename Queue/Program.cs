using System;
using System.Collections.Generic;

namespace Generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> dq = new Queue<int>();
            dq.Enqueue(10);                                     //Adds an item into the queue.
            dq.Enqueue(23);
            dq.Enqueue(16);
            dq.Enqueue(5);
            dq.Enqueue(29);
            Console.WriteLine("Queue items: ");
            foreach (int element in dq)
                Console.WriteLine(element);
            Console.WriteLine("Removing the front element = " + dq.Dequeue());          //Returns a item from the beginning of the queue and removes it from the queue.
            Console.WriteLine("Removing the next front element = " + dq.Dequeue());
            Console.WriteLine("Peeking at the current front element = " + dq.Peek());   //Returns a first item from the queue without removing it.
            Console.WriteLine("Updated Queue: ");
            foreach (int element in dq)
                Console.WriteLine(element);
        }
    }
}
