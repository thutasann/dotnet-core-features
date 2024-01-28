namespace data_structure_algo.src.LeetCodes
{
    public class TwoSum
    {
        public int[] TwoSumSolution(int[] nums, int target)
        {
            Console.WriteLine("------->> TwoSum Solution");
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
            System.Console.WriteLine("Empty Array");
            return Array.Empty<int>();
        }
    }
}