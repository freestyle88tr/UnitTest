using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{   
    /// <summary>
    /// Class Program 
    /// </summary>
    public class Program // class program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// add function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int add(int a, int b)
        {
            return (a + b);
        }
      
        /// <summary>
        /// subtract function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int subtract(int a, int b)
        {
            return (a - b);
        }

        /// <summary>
        /// multiply function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int multiply(int a, int b)
        {
            return (a * b);
        }

        /// <summary>
        /// divide function
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
