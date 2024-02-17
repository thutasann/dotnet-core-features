using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structure_algo.src.Basics
{
    public class NameOfKeywordSample
    {
        public int MyProperty { get; set; }
        public void SampleOne()
        {
            string myVariable;
            Console.WriteLine(nameof(myVariable)); // Output: myVariable
        }
    };

    public class Test
    {
        public void TestSample()
        {
            Console.WriteLine(nameof(NameOfKeywordSample.MyProperty));
            Console.WriteLine(nameof(NameOfKeywordSample.SampleOne));
        }
    }
}