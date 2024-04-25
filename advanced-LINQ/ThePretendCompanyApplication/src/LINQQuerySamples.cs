namespace ThePretendCompanyApplication.src
{

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }

    public static class LINQQuerySample
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nLINQ Query Sample : ");
            List<Person> persons = new()
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };

            IEnumerable<Person>? result = from p in persons
                                          where p.Age > 30
                                          select p;

            foreach (Person person in result)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}