namespace data_structure_algo.src.LeetCodes
{
    public class TwoSum
    {
        /// <summary>
        /// Two Sum Solution One
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumSolution(int[] nums, int target)
        {
            Console.WriteLine("------->> TwoSum Solution One");
            int i = 0;

            foreach (int item in nums)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        foreach (int result in new int[2] { i, j })
                        {
                            Console.WriteLine("Result ===> " + result);
                        }
                        return new int[2] { i, j };
                    }
                }
                i++;
            }
            Console.WriteLine("Empty Array");
            return Array.Empty<int>();
        }

        /// <summary>
        /// Two Sum Solution Two
        /// </summary>
        public int[] TwoSumSolutionTwo(int[] nums, int target)
        {
            Console.WriteLine("------->> TwoSum Solution Two");
            Dictionary<int, int> myDt = new();
            int index = 0;

            foreach (var num in nums)
            {
                if (myDt.ContainsKey(target - num))
                {
                    return new int[] { myDt[target - num], index };
                }
                else
                {
                    myDt.Add(num, index);
                }
                index++;
            }

            return new int[2];
        }

        /// <summary>
        /// Two Sum Solution Three
        /// </summary>
        public int[] TwoSumSolutionThree(int[] nums, int target)
        {
            Console.WriteLine("------->> TwoSum Solution Three");
            int firstCounter = 0;
            int secondCounter = 1;

            while (firstCounter < nums.Length)
            {
                if (secondCounter < nums.Length)
                {
                    if (nums[firstCounter] + nums[secondCounter] == target)
                        break;
                    secondCounter++;
                }
                else
                {
                    firstCounter++;
                    secondCounter = firstCounter + 1;
                }

                Console.WriteLine("First Counter " + firstCounter);
                Console.WriteLine("Second Counter " + secondCounter);
            }

            return new int[] { firstCounter, secondCounter };
        }
    }
}