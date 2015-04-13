using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Class
    /// </summary>
    public class Program // class program
    {

        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Add function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int add(int a, int b)
        {
            return (a + b);
        }
      
        /// <summary>
        /// Subtract function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int subtract(int a, int b)
        {
            return (a - b);
        }

        /// <summary>
        /// Multiply function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int multiply(int a, int b)
        {
            return (a * b);
        }

        /// <summary>
        /// Divide function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int divide(int a, int b)
        {
            return (a / b);
        }
    }
}
