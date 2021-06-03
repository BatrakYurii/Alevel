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
        /// Week.
        /// </summary>
        /// <param name="args">week.</param>
        public static void Main(string[] args)
        {
            Week week = new Week();
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
