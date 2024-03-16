namespace data_structure_algo.src.OOP.Encapsulation
{

    /// <summary>
    /// - The Car class encapsulates the data (make, model, year)  <br/>
    /// - The private fields (make, model, year) are encapsulated within the class and accessed through public properties (Make, Model, Year), providing controlled access to the outside world. <br/>
    /// - The constructor Car initializes the object with data. <br/>
    /// - The StartEngine method demonstrates functionality provided by the Car class.
    /// </summary>
    public class EnCar
    {
        private string? make;
        private string? model;
        private int year;

        public string Make
        {
            get { return make!; }
            set { make = value; }
        }

        public string Model
        {
            get { return model!; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1990 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Invalid year value.");
                }
            }
        }

        public EnCar(string Make, string Model, int Year)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }

        public void SartEngine()
        {
            Console.WriteLine($"Staring the {Make} {Model}'s engine...");
        }
    }
}