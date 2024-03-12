namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// `using` keyword <br/>
    /// - its primary uses are for importing namespaces and managing resources.
    /// </summary>
    public class UsingKeywordSample
    {
        public void SampleOne()
        {
            using var fileStream = new FileStream("example.txt", FileMode.Open);
        }
    }
}