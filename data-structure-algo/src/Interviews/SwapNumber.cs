namespace data_structure_algo.src.Interviews
{
    public class SwapNumber
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> SwapNumber Interview Sample One");
            int firstNumber = 2;
            int secondNumber = 4;
            int nTemp;

            Console.WriteLine("Before Swaping, first number {0} and second number {1}", firstNumber, secondNumber);

            nTemp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = nTemp;

            Console.WriteLine("After Swaping, first number {0} and second number {1}", firstNumber, secondNumber);
        }
    }
}