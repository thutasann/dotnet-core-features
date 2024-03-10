namespace data_structure_algo.src.OOP.Abstraction
{
    /// <summary>
    /// Abstraction in object-oriented programming(OOP) is the concept of hiding the complex implementation details of an object and only showing the essential features or behavior to the outside world
    /// </summary>    
    public abstract class VehicleSample
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public abstract void Drive();
    }

    public class AbstractCar : VehicleSample
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving {Make} {Model} - Vrom Vrom!");
        }
    }

    public class AbstractTruck : VehicleSample
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving {Make} {Model} - Rumble Rumble!");
        }
    }

    public class AbstractionVehicleSample
    {
        public void SampleOne()
        {
            VehicleSample car = new AbstractCar { Make = "Toyota", Model = "Camry" };
            VehicleSample truck = new AbstractTruck { Make = "Ford", Model = "F150" };

            // Use the Drive method without knowing the specific vehicle type
            car.Drive();   // Output: Driving Toyota Camry - Vroom Vroom!
            truck.Drive(); // Output: Driving Ford F150 - Rumble Rumble!
        }
    }
}