using System.Collections.ObjectModel;

namespace data_structure_algo.src.Searchings
{
    public class SequentialSearchSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Sequential Search Sample");
            Collection<int> numbers = new();
            Random random = new();
            for (int i = 0; i <= 10; i++)
            {
                numbers.Add((int)(random.NextDouble() * 100));
            }

            foreach (var item in numbers)
            {
                Console.WriteLine("initial num " + item);
            }

            bool result = SequentialSearch(numbers, 87);
            Console.WriteLine("result (true / false) => " + result);
        }

        static bool SequentialSearch(Collection<int> numbersList, int value)
        {
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}