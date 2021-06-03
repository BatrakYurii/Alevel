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
            var products = new DataStore();
            products.Add("iPhone");
            products.Add("iMac");
            products.Add("headphones");

            Console.WriteLine($"Количество товара {products.Count()}");
            products.Print();

            products.Remove("iMac");
            products.Add("Xiaomi");

            Console.WriteLine($"Количество товара {products.Count()}");
            products.Print();

        }
    }
}
