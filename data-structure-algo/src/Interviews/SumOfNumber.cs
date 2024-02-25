namespace data_structure_algo.src.Interviews
{
    public class SumOfNumber
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Sum Of Number (Interview)");
            int number = 234;
            int nTemp;
            int sumOfNumber = 0;

            while (number != 0)
            {
                nTemp = number % 10;
                number /= 10;
                sumOfNumber += nTemp;
            }
            Console.WriteLine("Sum of Given Number is {0}", sumOfNumber);
        }
    }
}