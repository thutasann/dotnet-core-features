namespace data_structure_algo.src.Interviews
{
    /// <summary>
    /// Reverse String  
    /// </summary>
    public class ReverseString
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Reverse String Sample One (Interview)");
            string sourceString = "abcdefghijk";
            string reverseString = "";

            for (int i = sourceString.Length - 1; i >= 0; i--)
            {
                reverseString += sourceString[i];
            }

            Console.WriteLine("Source String is {0} \n Reverse String is {1}", sourceString, reverseString);
        }
    }

    /// <summary>
    /// Reverse Number
    /// </summary>
    public class ReverseNumber
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Reverse Number Sample One (Interview)");
            int sourceNumber = 1234567;
            int reverseNumber = 0;

            while (sourceNumber != 0)
            {
                reverseNumber *= 10;
                reverseNumber += sourceNumber % 10;
                sourceNumber /= 10;
            }

            Console.WriteLine("The Reverse Number is {0}", reverseNumber);
        }

        public void SampleTwo()
        {
            Console.WriteLine("------>> Reverse Number Sample Two (Interview)");
            int number = 123;
            int reminder, reverseNumber = 0;

            while (number > 0)
            {
                reminder = number % 10;
                number /= 10;
                reverseNumber = (reverseNumber * 10) + reminder;
            }
            Console.WriteLine("reverse number " + reverseNumber);
        }
    }
}