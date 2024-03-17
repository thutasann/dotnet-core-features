namespace data_structure_algo.src.OOP.Abstraction
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string Name)
        {
            this.Name = Name;
        }
    }

    public class Professor
    {
        public string Name { get; set; }

        public Professor(string Name)
        {
            this.Name = Name;
        }
    }

    /// <summary>
    /// Hiding the complex implementation details of a class and only exposing the essential features through well-defined interfaces <br/>
    /// - The ICourse interface defines the abstraction for a course,
    /// </summary>
    public interface ICourse
    {
        string Title { get; }
        string Description { get; }
        void Enroll(Student student);
        void AssignProfessor(Professor professor);
    }

    /// <summary>
    /// Define the concrete implementation of a course
    /// </summary>
    public class Course : ICourse
    {
        private readonly string title;
        private readonly string description;
        private readonly List<Student>? EncrolledStudents;
        private Professor AssignedProfessor;

        public Course(string Title, string Description)
        {
            title = Title;
            description = Description;
            AssignedProfessor = new Professor("Default Professor");
        }

        public string Title
        {
            get { return title; }
        }

        public string Description
        {
            get { return description; }
        }

        public void AssignProfessor(Professor professor)
        {
            AssignedProfessor = professor;
            Console.WriteLine($"Professor {professor.Name} assigned to teach the course : {Title}");
        }

        public void Enroll(Student student)
        {
            EncrolledStudents?.Add(student);
            Console.WriteLine($"{student.Name} enrolled in the course : {Title}");
        }
    }

    public class CourseUsage
    {
        public void SampleOne()
        {
            Course course = new("C# Programming", "Introduction to C#");

            Student student1 = new("John");
            Student student2 = new("Emily");

            Professor professor = new("Dr. Smith");

            course.Enroll(student1);
            course.Enroll(student2);
            course.AssignProfessor(professor);
        }

    }
}