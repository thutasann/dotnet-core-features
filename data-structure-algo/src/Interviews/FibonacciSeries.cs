namespace data_structure_algo.src.Interviews
{
    /// <summary>
    /// <h1> FIBONACCI SERRIES </h1> <br/>
    /// Series of numbers in which each number is the sume of two preceeding numbers <br/>
    /// <i> (Preceding number means number just before a number. Example: In a counting from 1 to 10, 9 is preceding number of 10, 8 is preceding number of 9 and so on) </i> <br/>
    /// Examples : <br/>
    /// 0, 1, 1, 2, 3, 5, 8... <br/>
    /// 0 + 1 => 1, 1 + 1 => 2, 2 + 3 => 5, 3 + 5 => 8
    /// </summary>
    public class FibonacciSeries
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> FibonacciSeries Interview Sample One");
            int number = 8;
            int previousNumber = -1;
            int nextNumber = 1;

            for (int i = 0; i < number; i++)
            {
                int sumNumber = previousNumber + nextNumber;
                Console.WriteLine("sumNumber {0} of prev {1} + next {2} ", sumNumber, previousNumber, nextNumber);
                previousNumber = nextNumber;
                nextNumber = sumNumber;
            }
        }
    }
}