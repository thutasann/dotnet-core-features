namespace data_structure_algo.src.Sortings
{
    /// <summary>
    /// This sorting is more efficient than BubbleSort. <br/>
    /// Its a <b>in-place sorting algorithm</b> with a time complexity of BigO N Squared and <br/>
    /// Space Complexity of BigO One aka constant space. <br/>
    /// We swapped the smallest element with the first element in an array. <br/>
    /// So We searched the entire array before we swap the elements <br/>
    /// Then we move our pointer to the second element in the array. <br/>
    /// Then we find the next smallest element in the array. <br/>
    /// Then we swapped that smallest element with the second position in the array. <br/>
    /// Then we continues this until we get to the end of the array. <br/>
    /// And then all Elements will be sorted.
    /// </summary>
    public class SelectionSortSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Selection Sort Sample One");
            double[] unsortedList = { 10, 4, 8, 6, 7 };
            SelectionSort(unsortedList);
        }

        public static void SelectionSort(double[] unsortedList)
        {
            int MinIndex = 0; // current index of the current minimum we are looking for
            double MinimumValueFound = 0; // temporary variable for swapping the value of the current min index

            // MainIndex is the pointer for each lowest element we need to find
            for (int MainIndex = 0; MainIndex < unsortedList.Length; MainIndex++)
            {
                // MinIndex is now the current spot in the Main List
                MinIndex = MainIndex;

                // Remaining goes threw the remainder of the list finding the index of the next lowest value
                for (int RemainingIndex = MainIndex + 1; RemainingIndex < unsortedList.Length; RemainingIndex++)
                {
                    // If the remaining element is less than the MinIndex, we move the index to that spot
                    // Will swap values after going through the entire List
                    if (unsortedList[RemainingIndex] < unsortedList[MinIndex]) // we are finding the next smallest element
                    {
                        MinIndex = RemainingIndex;
                    }
                }

                // We now have the index of the Lowest number in the remaining List. Swap it with the current i element in the list.
                MinimumValueFound = unsortedList[MinIndex];
                unsortedList[MinIndex] = unsortedList[MainIndex];
                unsortedList[MainIndex] = MinimumValueFound;
            }

            foreach (var item in unsortedList)
            {
                Console.WriteLine("sortedList " + item);
            }
        }
    }
}