using System.Collections.ObjectModel;

namespace data_structure_algo.src.Sortings
{
    /// <summary>
    /// A recursive Algorithm <br/>
    /// which works by breaking the dataset up into two halves And recursively sorting each half <br/>
    /// When the Two halves are sorted, they are brought together using a merge routine. <br/>
    /// <b> Easy Simple words </b> <br/> 
    /// Divide the unsorted list into `n sub lists` each containing one element <br/>
    /// A list of one element is considered sorted <br/>
    /// Repeatedly merge sub lists to produce new sorted sub lists until there is only one sub list remaining. <br/>
    /// This will be sorted sub list
    /// </summary>
    public class MergeSortSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Merge Sort Sample One");
            Collection<int> unsortedList = new();
            Random random = new(100);
            for (int i = 0; i <= 10; i++)
            {
                unsortedList.Add((int)(random.NextDouble() * 100));
            }
            foreach (var unsorted in unsortedList)
            {
                Console.WriteLine("unsorted " + unsorted);
            }

            var sortedList = MergeSort(unsortedList);
            Console.WriteLine("------------------");

            foreach (var sorted in sortedList)
            {
                Console.WriteLine("sorted " + sorted);
            }
        }

        /// <summary>
        /// Merge Sort
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static Collection<int> MergeSort(Collection<int> collection)
        {
            Collection<int> left = new();
            Collection<int> right = new();
            int middle = 0;
            middle = collection.Count / 2;

            // Add to Left
            for (int i = 0; i < middle; i++)
            {
                left.Add(collection[i]);
            }

            int itemCount = 0;
            itemCount = collection.Count;

            // Add to Right
            for (int i = middle; i < itemCount; i++)
            {
                right.Add(collection[i]);
            }

            left = MergeSort(collection);
            right = MergeSort(collection);
            return Merge(left, right);
        }

        /// <summary>
        /// Merge Left and Right Method
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Collection<int> Merge(Collection<int> left, Collection<int> right)
        {
            Collection<int> result = new();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    // comparing first two elements which one is smaller
                    if ((int)left.First() <= (int)right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}