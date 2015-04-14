namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class
    /// </summary>
    public class Program 
    {
        /// <summary>
        /// Add function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>returns a + b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtract function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>returns a - b</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiply function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>returns a * b </returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>returns a / b</returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Application is running");
        }
    }
}
