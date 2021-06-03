using System;
using System.Collections.Generic;

namespace HomeTask
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Class Program.
        /// </summary>
        /// <param name="args">arrayStack - an object of type Stack.</param>
        public static void Main(string[] args)
        {
            var arrayStack = new Stack<string>();
            arrayStack.Push("First element");
            arrayStack.Push("Second element");
            arrayStack.Push("Third element");

            Console.WriteLine(arrayStack.Peek());

            arrayStack.Pop();
            arrayStack.Push("Last element");

            Console.WriteLine(arrayStack.Peek());
        }
    }
}
