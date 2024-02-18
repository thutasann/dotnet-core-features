namespace data_structure_algo.src.LeetCodes
{
    /// <summary>
    /// Given a string <b>s</b>. <br/>
    /// Find the length of the longest substring without repeating characters <br/>
    /// Will use `Two Pointer` mechanism.
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Sample One
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static void SampleOne(string stringValue)
        {
            Dictionary<char, int> uniqueCharacter = new();
            int length = stringValue.Length;

            int i = 0; // slower index (i will move one character at a time)
            int j = 0; // faster index (j will move faster)
            int max = 0;

            while (j < length)
            {
                if (uniqueCharacter.ContainsKey(stringValue[j]))
                {
                    uniqueCharacter.Remove(stringValue[i]); // remove first char
                    i++;
                }
                else
                {
                    uniqueCharacter.Add(stringValue[j], j);
                    max = Math.Max(max, uniqueCharacter.Count);
                    j++;
                }
            }
            Console.WriteLine("Result " + max);
        }
    }
}