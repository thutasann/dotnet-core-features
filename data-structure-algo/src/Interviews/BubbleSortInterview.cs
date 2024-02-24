namespace data_structure_algo.src.Interviews
{
    public class BubbleSortInterview
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Bubble Sort Interview Sample One");
            int[] UnsortedNumbers = { 30, 10, -90, -40, 50, 25, 70, -54, -80, 38 };
            int nTemp = 0;

            Console.WriteLine("Sorted Numbers are....");
            // outer loop is for responsible for looping all number from List
            for (int i = 0; i < UnsortedNumbers.Length; i++)
            {
                // inner loop is responsible for finding lowest number and swap the array
                // i + 1 => finding next number
                for (int j = i + 1; j < UnsortedNumbers.Length; j++)
                {
                    // check for the lowest number and then swap
                    if (UnsortedNumbers[i] > UnsortedNumbers[j])
                    {
                        nTemp = UnsortedNumbers[j];
                        UnsortedNumbers[j] = UnsortedNumbers[i];
                        UnsortedNumbers[i] = nTemp;
                    }
                }
            }

            foreach (int item in UnsortedNumbers)
            {
                Console.WriteLine("Sorted " + item);
            }
        }
    }
}