namespace data_structure_algo.src.Arrays
{
    public class ArraySample
    {
        /// <summary>
        /// Array End Insertion
        /// </summary>
        public void ArrayEndInsertion()
        {
            Console.WriteLine("------- Array End Insertaion");
            int[] intArray = new int[6];
            // Make a variable to keep the length because .Length is based off capacity and does track the actual index
            int length = 0;

            for (int i = 0; i < 5; i++)
            {
                intArray[length] = i;
                length++;
            }

            intArray[length] = 20;

            foreach (int intNum in intArray)
            {
                // just for console logs
                Console.WriteLine("inNum => " + intNum);
            }

        }

        /// <summary>
        /// Array Start Insertion
        /// </summary>
        public void ArrayStartInsertion()
        {
            Console.WriteLine("------- Array Start Insertion");
            int[] intArray = new int[6];
            int length = 0;

            for (int i = 0; i < 5; i++)
            {
                intArray[length] = i;
                length++;
            }

            for (int i = 3; i >= 0; i--)
            {
                // this is moving over all the values;
                intArray[i + 1] = intArray[i];
                length++;
            }

            intArray[0] = 20;


            foreach (int intNum in intArray)
            {
                // just for console logs
                Console.WriteLine("inNum => " + intNum);
            }
        }

        /// <summary>
        /// Array AnyWhere Insertion
        /// </summary>
        public void ArrayAnyWhereInsertion()
        {

        }
    }
}