namespace data_structure_algo.src.Interviews
{
    /// <summary>
    /// Prime numbers are numbers which are divisible by 1 and by itself. <br/>
    /// Prime numbers are having two factors, 1 and by itself. <br/>
    /// 0 and 1 are not considered as prime numbers <br/>
    /// 2 is even prime number. It is smallest prime numbers <br/>
    /// 2, 3, 5, 7, 11, 13, 17, 19, 23.. <br/>
    /// <b> Why 23 is Prime </b> <br/>
    /// Divisor 1: 23 ÷ 1 = 23 <br/>
    /// Divisor 23: 23 ÷ 23 = 1
    /// <b> Why 20 is not Prime </b> <br/>
    /// It can be divided evenly by 2 (20 ÷ 2 = 10). <br/>
    /// It can be divided evenly by 4 (20 ÷ 4 = 5). <br/>
    /// </summary>
    public class PrimeNumbers
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Prime Number (Interview)");
            int nMaxNumber = 23; // would be user's input.
            bool isPrimeNumber = false;
            Console.WriteLine("Prime numbers between {0} and {1} are ", 2, nMaxNumber);

            // outer loop is responsible for checking the max number
            for (int i = 2; i <= nMaxNumber; i++)
            {
                // inner loop is responsible for checking the factors
                for (int j = 2; j <= nMaxNumber; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine("prime number " + i);
                }
                isPrimeNumber = true;
            }
        }

    }
}