using System.Collections.ObjectModel;

namespace data_structure_algo.src.Searchings
{
    /// <summary>
    /// Binary Search Sample
    /// </summary>
    public class BinarySearchSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Binary Search Sample One BuitIn");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = Array.BinarySearch(numbers, 6);
            Console.WriteLine("The number 6 is at index " + index);
        }

        public void SampleTwo()
        {
            Console.WriteLine("------>> Binary Search Sample Two Custom");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 4;
            int index = BinarySearch(numbers, target);

            if (index != -1)
            {
                Console.WriteLine($"The value {target} is found at index {index}");
            }
            else
            {
                Console.WriteLine("Value not Found");
            }
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                Console.WriteLine("mid " + mid);

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }

            return -1;
        }
    }

    /// <summary>
    /// Recursive Binary Search Sample
    /// </summary>
    public class RecursiveBinarySearchSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Recursive Binary Search Sample One");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 4;
            int index = RBinarySearch(numbers, 4, 0, numbers.Length - 1);
            Console.WriteLine($"The value {target} is found at index {index}");
        }

        /// <summary>
        /// Recursive Binary Search
        /// </summary>
        /// <param name="array">Sorted List</param>
        /// <param name="target">Target</param>
        /// <param name="lower">First Item</param>
        /// <param name="upper">Last Item</param>
        /// <returns></returns>
        static int RBinarySearch(int[] array, int target, int lower, int upper)
        {
            if (lower <= upper)
            {
                int mid;
                mid = (lower + upper) / 2;

                if (target < array[mid])
                {
                    return RBinarySearch(array, target, lower, mid - 1);
                }
                else if (target == array[mid])
                {
                    return mid;
                }
                else
                {
                    return RBinarySearch(array, target, mid + 1, upper);
                }
            }
            return -1;
        }
    }
}