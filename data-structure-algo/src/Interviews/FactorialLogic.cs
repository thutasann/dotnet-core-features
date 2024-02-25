namespace data_structure_algo.src.Interviews
{
    /// <summary>
    /// <h1> Factorial Logic </h1> <br/>
    /// Multiply a series of descending natural numbers. (Largest to smalles) <br/>
    /// Fact: Zero factorial is 1 <br/>
    /// 1 factorial = 1 * 1 = 1 <br/>
    /// 2 factorial = 2 * 1 = 2 <br/>
    /// 3 factorial = 3 * 2 * 1 = 6 <br/>
    /// 4 factorial = 4 * 3 * 2 * 1 = 24 <br/>
    /// 5 factorial = 5 * 4 * 3 * 2 * 1 = 120 <br/>
    /// </summary>
    public class FactorialLogic
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Factorial Logic Interview Sample One");
            int number = 3;
            int factorial = 1;

            if (number < 0)
            {
                Console.WriteLine("Factorials are not applicable for negative numbers");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero factorial is 1");
            }
            else
            {
                for (int i = number; i >= 1; i--)
                {
                    factorial *= i;
                }
                Console.WriteLine("{0} factorial is {1}", number.ToString(), factorial.ToString());
            }
        }
    }
}