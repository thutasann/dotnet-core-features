namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// <h1> Base Keyword </h1> <br/>
    ///  base keyword is used to access members of the base class (or superclass) in a derived class (or subclass). It allows you to call constructors, methods, and properties of the base class from within the derived class.
    /// </summary>
    public class BaseKeyword
    {
    }

    // ------------ Calling the Base Class Constructor ------------
    public class BaseClassSample
    {
        public BaseClassSample(int value)
        {
            // Constructor Logic
        }
    }

    public class DerivedClassSample : BaseClassSample
    {
        //In this example, the base(value) constructor call in the DerivedClass constructor calls the constructor of the BaseClass with the provided value.
        public DerivedClassSample(int value) : base(value)
        {

        }
    }

    // ------------ Calling the Base Class Methods ------------
    public class BaseClassMethod
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("This is From Base Class");
        }
    }

    public class DerivedClassMethod : BaseClassMethod
    {
        public override void BaseMethod()
        {
            base.BaseMethod(); // call the baes class method
            Console.WriteLine("This is From Derived Class");
        }
    }

}