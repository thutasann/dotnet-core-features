namespace data_structure_algo.src.Basics
{
    public class MyClass
    {
        public int MyProperty { get; set; }

        public MyClass()
        {
            MyProperty = 10;
        }

        public MyClass(int MyProperty)
        {
            this.MyProperty = MyProperty;
        }
    }

    public class Program
    {
        MyClass myClass = new();
        MyClass myClassTwo = new(10);
    }
}