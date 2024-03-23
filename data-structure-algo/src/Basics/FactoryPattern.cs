namespace data_structure_algo.src.Basics
{

    /// <summary>
    /// Factory Pattern Sample <br/>
    /// In essense, the Factory Pattern defines an interface or abstract class for createing objects (often referred to as the factory), and concrete subclasses or methods withing the factory are responsible for creating instances of objects.
    /// </summary>
    public class FactoryPattern
    {
    }

    // --------- Interface or base class
    public interface IFacShape
    {
        void Draw();
    }

    // --------- Concret Implementations
    public class FacCircle : IFacShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    public class FacRectange : IFacShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    public class FacSquare : IFacShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    // --------- Factory Class
    public class ShapeFactory
    {
        public IFacShape CreateShape(string type)
        {
            return type switch
            {
                "Circle" => new FacCircle(),
                "Rectangle" => new FacRectange(),
                "Square" => new FacSquare(),
                _ => throw new ArgumentException("Invalid Shape Type"),
            };
        }
    }

    // --------- Factory Shape Usage
    public class FactoryShapeUsage
    {
        public void SampleOne()
        {
            ShapeFactory shapeFactory = new();

            IFacShape circle = shapeFactory.CreateShape("Circle");
            circle.Draw();

            IFacShape rectangle = shapeFactory.CreateShape("Rectangle");
            rectangle.Draw();

            IFacShape square = shapeFactory.CreateShape("Square");
            square.Draw();
        }
    }
}