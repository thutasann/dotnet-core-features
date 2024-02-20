using System.Collections.ObjectModel;

namespace data_structure_algo.src.Sortings
{
    public class SelectionSortSampleTwo
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Selection Sort Sample Two");
            Collection<int> numbers = new();
            Random random = new();
            for (int i = 0; i <= 10; i++)
            {
                numbers.Add((int)(random.NextDouble() * 100));
            }

            Collection<int> sortedList = SelectionSort(numbers);

            foreach (var item in sortedList)
            {
                Console.WriteLine("sorted list " + item);
            }
        }

        static Collection<int> SelectionSort(Collection<int> numbers)
        {
            int upper = numbers.Count - 1;
            int min;
            object temp;

            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    Console.WriteLine("outer {0} , inner {1}", outer, inner);
                    if (numbers[inner] < numbers[min])
                    {
                        min = inner;
                    }
                }
                temp = numbers[outer];
                numbers[outer] = numbers[min];
                numbers[min] = (int)temp;
            }
            return numbers;
        }
    }
}