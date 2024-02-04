namespace data_structure_algo.src.Basics
{
    public record Person(string FirstName, string LastName);

    public class WithSample
    {
        public void SampleOne()
        {
            var person1 = new Person("Thuta", "Sann");
            var person2 = person1 with { LastName = "Sann Updated" };

            Console.WriteLine("Original Person 1 => " + person1.FirstName + " " + person1.LastName);
            Console.WriteLine("Updated Person 2 => " + person2.FirstName + " " + person2.LastName);
        }
    }
}