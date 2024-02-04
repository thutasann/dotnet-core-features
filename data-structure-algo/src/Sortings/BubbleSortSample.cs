using System.Collections.ObjectModel;

namespace data_structure_algo.src.Sortings
{
    /// <summary>
    /// Values Float like a bubble from one end of the list to the other end <br/>
    /// Higher values will go to the right and Lower values will go to the left <br/>
    /// You pick one number and you compare it and you compare with the adjacent (close) number <br/>
    /// if the number you have picked is greater than the number which you are comparing it then <br/>
    /// the picked number will be moved towards right <br/>
    /// In place sorting algorithm so it takes contant space <br/>
    /// its also a stable sort <br/>
    /// </summary>
    public class BubbleSortSample
    {
        public void SampleOne()
        {
            double[] unsortedList = new double[] { 36, 2, 29, 1, 8, 14 };
            foreach (double item in unsortedList)
            {
                Console.WriteLine("unsortedList " + item);
            }
            Console.WriteLine("------------------");
            double[] sortedList = BubbleSort(unsortedList);

            foreach (double item in sortedList)
            {
                Console.WriteLine("sortedList " + item);
            }
        }

        /// <summary>
        /// Go to each index and compares to the next number if the number is greater than the next number then they are swaped. So the next largest numbers moves all the way to the right on each pass
        /// </summary>
        public static double[] BubbleSort(double[] unsortedList)
        {
            double temp;

            // we loop through 1 less than tthe length of the unsorted array because we comparing to the number after the current number. Thus do not need to go to the last position as there will be no number after it.
            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                // i is the current position we solve for
                // add i not to go to the last element as that element has already been moved to the right
                for (int j = 0; j < unsortedList.Length - (i + 1); j++)
                {
                    // first to the last element [0] > [1] -> [4] -> [5]
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        // if current is greater than next swap it forward
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }

            return unsortedList;
        }

    }
}