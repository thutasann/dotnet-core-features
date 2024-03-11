namespace data_structure_algo.src.OOP.Polymorphism
{
    /// <summary>
    /// # Virtual Keyword <br/>
    /// - virtual keyword is used to declare a method, property, or indexer in a base class that can be overridden by derived classes. Here's how it works: <br/>
    /// - When a method is declared as virtual in a base class, it means that derived classes can provide their own implementation of that method using the override keyword. <br/>
    /// - The virtual method provides a default implementation that can be optionally overridden by derived classes. <br/>
    /// </summary>
    public class VirtualKeywordSample
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("This is Base Method");
        }
    }

    public class DerivedClass : VirtualKeywordSample
    {
        public override void BaseMethod()
        {
            Console.WriteLine("Overriding the base method");
        }
    }
}