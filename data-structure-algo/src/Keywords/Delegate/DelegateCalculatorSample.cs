namespace data_structure_algo.src.Keywords.Delegate
{
    public delegate int CalcuationDelegate(int x, int y);

    public class Claculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }

    public class DelgateCalculatorUsage
    {
        public void SampleOne()
        {
            Claculator claculator = new();

            CalcuationDelegate addDelegate = claculator.Add;
            CalcuationDelegate subtractDelegate = claculator.Subtract;

            int result1 = PerformCalculation(10, 5, addDelegate);
            int result2 = PerformCalculation(10, 5, subtractDelegate);

            Console.WriteLine($"Result of addition: {result1}");
            Console.WriteLine($"Result of subtraction : {result2}");
        }

        static int PerformCalculation(int x, int y, CalcuationDelegate calcuation)
        {
            return calcuation(x, y);
        }
    }
}