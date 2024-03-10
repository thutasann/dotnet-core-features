namespace data_structure_algo.src.Basics
{
    public record Person(string FirstName, string LastName);
    public record Student(string FullName, int grade);

    public class WithSample
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> With Expression");
            var person1 = new Person("Thuta", "Sann");
            var person2 = person1 with { LastName = "Sann Updated" };

            Console.WriteLine("Original Person 1 => " + person1.FirstName + " " + person1.LastName);
            Console.WriteLine("Updated Person 2 => " + person2.FirstName + " " + person2.LastName);
        }
    }

    public class WithSamplePractice
    {
        public void SampleOne()
        {
            var student1 = new Student("Thuta Sann", 1);
            var student2 = new Student("Kyaw Kyaw", 2);

            var updatedStudent1 = student1 with { FullName = "Thuta Sann Updated" };
            var updatedStudent2 = student2 with { grade = 1 };

            Console.WriteLine("Updated Student One => " + updatedStudent2.FullName);
            Console.WriteLine("Updated Student Two => " + updatedStudent2.grade);
        }
    }
}