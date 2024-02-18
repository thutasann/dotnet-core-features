using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace data_structure_algo.src.Basics
{
    /// <summary>
    /// Print first N natural number using Recursion
    /// first N Natural Number (e.g. N = 5)
    /// </summary>
    public class RecursionSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Recursion Sample");
            PrintNumber(1, 3);
        }

        /// <summary>
        /// Recursive Sample Method
        /// </summary>
        static int PrintNumber(int startingValue, int counter)
        {
            if (counter < 1)
            {
                return startingValue;
            }
            counter--;
            Console.WriteLine($"{startingValue}");
            return PrintNumber(startingValue + 1, counter);
        }
    }
}