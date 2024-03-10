namespace data_structure_algo.src.Basics.Generic
{
    /// <summary>
    /// Generic Function Sample
    /// </summary>
    public class GenericFunctionSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Generic Function Sample");
            int num1 = 300;
            int num2 = 500;
            Swap<int>(ref num1, ref num2);
            Console.WriteLine("num1 " + num1);
            Console.WriteLine("num2 " + num2);

            string str1 = "John";
            string str2 = "Matt";
            Swap<string>(ref str1, ref str2);
            Console.WriteLine("str1 " + str1);
            Console.WriteLine("str2 " + str2);
        }

        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }

    /// <summary>
    /// Generif Class Sample
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericLinkedList<T>
    {
        public T Data { get; set; }
        public GenericLinkedList<T?>? Link { get; set; }

        public GenericLinkedList(T Data, GenericLinkedList<T?>? Link)
        {
            this.Data = Data;
            this.Link = Link;
        }
    }
}