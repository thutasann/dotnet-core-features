namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// `out` keyword is used in method parameters to indicate that <br/>
    /// the parameter is an output parameter. <br/>
    /// This means that parameter is passed by reference rather that by value. <br/>
    /// and the method is expected to assign a value to it.
    /// </summary>
    public class OutKeywordSample
    {
        public static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            if (divisor != 0)
            {
                quotient = dividend / divisor;
                remainder = dividend % divisor;
            }
            else
            {
                quotient = 0;
                remainder = 0;
            }
        }
    }

    public class OutKeywrdSampleUsage
    {
        public void SampleOne()
        {
            int dividend = 10;
            int divisor = 3;
            int resultQuotient;
            int resultRemainder;

            // Call the method with out parameters
            OutKeywordSample.Divide(dividend, divisor, out resultQuotient, out resultRemainder);

            Console.WriteLine($"Quotient: {resultQuotient}, Remainder: {resultRemainder}");
        }
    }
}