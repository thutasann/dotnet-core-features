namespace data_structure_algo.src.Arrays
{
    /// <summary>
    /// Jagged Array is an array of arrays where <br/>
    /// each row of an array is made up of an array <br/>
    /// each dimension of a jagged array is an one-dimensional array <br/>
    /// The number of elements in each row maybe different
    /// </summary>
    public class JaggedArraySample
    {
        public void SampleOne()
        {
            int[] Jan = new int[31];
            int[] Feb = new int[29];
            int[][] sales = new int[][] { Jan, Feb };
            int month, day, total;
            double average = 0.0;

            sales[0][0] = 41;
            sales[0][1] = 42;
            sales[0][2] = 43;
            sales[0][3] = 44;
            sales[0][4] = 48;
            sales[0][5] = 45;
            sales[0][6] = 45;
            sales[1][0] = 45;
            sales[1][1] = 47;
            sales[1][2] = 42;
            sales[1][3] = 46;
            sales[1][4] = 45;
            sales[1][5] = 48;
            sales[1][6] = 42;

            for (month = 0; month <= 1; month++)
            {
                total = 0;
                for (day = 0; day <= 6; day++)
                {
                    total += sales[month][day];
                }
                average = total / 7;
                Console.WriteLine("average Sales for Month " + month + ":" + average);
            }
            Console.ReadLine();
        }
    }
}