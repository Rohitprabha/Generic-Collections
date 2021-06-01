using System;
using System.Collections.Generic;

namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(10);                                                    //Inserts an item at the top of the stack.
            st.Push(32);
            st.Push(12);
            st.Push(3);
            st.Push(27);
            Console.WriteLine("Stack Elements: ");
            foreach (int element in st)
                Console.WriteLine(element);
            Console.WriteLine("Popping out the top element = " + st.Pop());         //Removes and returns items from the top of the stack.
            Console.WriteLine("Popping out the next top element = " + st.Pop());
            Console.WriteLine("Peeking at the current top element = " + st.Peek());     //Returns the top item from the stack.
            Console.WriteLine("The updated Stack: ");
            foreach (int element in st)
                Console.WriteLine(element);
        }
    }
}
