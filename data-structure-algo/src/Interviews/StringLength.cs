namespace data_structure_algo.src.Interviews
{
    public class StringLength
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> String Length Sample One (Interview)");
            string strSource = "abcdefg";
            int nCount = 0;

            foreach (char item in strSource)
            {
                nCount++;
            }
            Console.WriteLine("String {0} Length is {1}", strSource, nCount);
        }
    }
}