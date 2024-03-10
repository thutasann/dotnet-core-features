namespace data_structure_algo.src.Basics.ThreadSample
{
    public class DataProcessingSample
    {
        public void SampleOne()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("Data Processing Sample => ");
            List<string> MRTData = GenerateData("Singapore MRT", 10);
            List<string> MOMData = GenerateData("MOM Data", 10);

            Thread mrtThread = new(() => ProcessDataAsync("MRT", MRTData));
            mrtThread.Start();

            Thread momThread = new(() => ProcessDataAsync("MOM", MOMData));
            momThread.Start();

            // wait for both thread to complete
            mrtThread.Join();
            momThread.Join();

            var endTime = DateTime.Now;
            Console.WriteLine($"All data processed successfully {(endTime - startTime) / 1000} seconds");
        }

        private static void ProcessDataAsync(string dataType, List<string> data)
        {
            foreach (var item in data)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Processing {dataType} data: {item}");
            }
        }


        /// <summary>
        /// Util function to generate data
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private static List<string> GenerateData(string serviceName, int count)
        {
            List<string> data = new();
            for (int i = 0; i < count; i++)
            {
                data.Add($"{serviceName} Data {i + 1}");
            }
            return data;
        }
    }
}