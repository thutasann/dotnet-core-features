namespace advanced_c_.src.Pointers
{
    public static class PointerSampleOne
    {
        public static void Intro()
        {
            Console.WriteLine("\nPointer Intro : ");
            unsafe
            {
                int val = 50;
                int* x = &val;
                Console.WriteLine($"Data : {val}");
                Console.WriteLine($"Address: {(int)x}");
            }
        }

        public static unsafe void IntroTwo()
        {
            Console.WriteLine("\nPointer Intro Two : ");
            int x = 100;
            int* ptr = &x;
            Console.WriteLine("Memory => " + (int)ptr);
            Console.WriteLine("Value => " + *ptr);
        }

        public static unsafe void UnsafeMethod()
        {
            Console.WriteLine("\nUnsafe Method : ");
            int x = 10;
            int y = 20;
            int* ptr = &x;
            int* ptr2 = &y;

            Console.WriteLine("Memory One => " + (int)ptr);
            Console.WriteLine("Memory Two => " + (int)ptr2);
            Console.WriteLine("Value One => " + *ptr);
            Console.WriteLine("Value Two => " + *ptr2);
        }
    }

    public static class PointerAndMethod
    {
        public static unsafe void SampleMethod()
        {
            Console.WriteLine("\nPointer and Method :");
            int value = 10;
            int result;

            SquareByRef(ref value);
            Console.WriteLine("Value after squaring by reference: " + value);

            int* ptr = &value;
            result = SquareByPointer(ptr);
            Console.WriteLine("Value after squaring by pointer-like operation: " + result);
        }

        private static void SquareByRef(ref int val)
        {
            val *= val;
        }

        private static unsafe int SquareByPointer(int* ptr)
        {
            return *ptr * (*ptr);
        }
    }
}