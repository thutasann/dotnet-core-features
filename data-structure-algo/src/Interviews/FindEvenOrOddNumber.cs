namespace data_structure_algo.src.Interviews
{
    public class FindEvenOrOddNumber
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Find Even or Odd Number (Interview)");
            int number = 7;

            if (number % 2 == 0)
            {
                Console.WriteLine("Number {0} is Even Number", number);
            }
            else
            {
                Console.WriteLine("Number {0} is Odd Number", number);
            }
        }
    }
}