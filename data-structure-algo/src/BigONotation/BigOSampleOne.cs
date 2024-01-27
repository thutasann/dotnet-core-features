namespace data_structure_algo.src.BigONotation
{
    /// <summary>
    /// BigO Notation
    /// O(1) - "Constant"
    /// O(N) - "Linear" -> ForLoop
    /// O(N^2) - "Quadratic
    /// </summary>
    public class BigOSampleOne
    {


        /// <summary>
        /// O(N) Sample
        /// </summary>
        public void ONSample()
        {
            int total = 0; // O(1)
            int i = 2;

            while (i <= 10) // O(N)
            {
                total++;
                i++;
            }
        }

        /// <summary>
        /// Quadratic Sample
        /// </summary>
        public void QuadraticSample()
        {
            var n = int.Parse((string)Console.ReadLine()!);
            for (var r = 1; r <= n; r++)
            {
                for (int c = 0; c <= n; c++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }

    }
}