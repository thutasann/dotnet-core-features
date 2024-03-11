namespace data_structure_algo.src.OOP.Polymorphism
{
    /// <summary>
    /// #Polymorphism
    /// - that allows objects of different types to be treated as objects of a common base type. <br/>
    /// - Compile-time Polymorphism (Static Polymorphism) <br/>
    ///     - Method Overloading: Allows a class to have multiple methods with the same name but different parameters. <br/>
    ///     - Operator Overloading: Allows operators like +, -, *, /, etc., to be overloaded so that they can operate on user-defined types. <br/>
    /// - Run-time Polymorphism (Dynamic Polymorphism) <br/>
    ///     - Method Overriding: Allows a derived class to provide a specific implementation of a method that is already defined in its base class. This is achieved using inheritance and the virtual and override keywords.
    /// </summary>
    public class PolymorphismSample
    {
    }

    /// <summary>
    /// Base Shape Class
    /// </summary>
    public class PolyShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    /// <summary>
    /// Derived class overriding the Draw method
    /// </summary>
    public class Circle : PolyShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    /// <summary>
    /// Derived class overriding the Draw method
    /// </summary>
    public class Rectangle : PolyShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    /// <summary>
    /// # Properties and Indexers:
    /// - Similar to methods, properties and indexers can also be declared as virtual, allowing derived classes to override them with their own implementations.
    /// </summary>
    public class PropertiesAndIndexers { }

    public class PolyVehicle
    {
        public virtual required string Name { get; set; }
    }

    public class PolyCar : PolyVehicle
    {
        private string? _name;

        public override required string Name { get => _name!; set => _name = value.ToUpper(); }
    }


}