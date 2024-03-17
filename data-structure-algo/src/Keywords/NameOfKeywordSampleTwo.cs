namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// in c#, `namof` operator is used to obtain the simple (unqualified) string name of <br/>
    /// a variable, type, or member. it provides a way to refer to the name of a code element <br/>
    /// in a strongly-typed member, reducing the likelihook of errors caused by hardcoding names as tring 
    /// </summary>
    public class NameOfKeywordSampleTwo
    {

        public void SampleOne()
        {
            VariableSample();
            TypeNameSample();
            MemberNameTypeSample();
        }

        private void VariableSample()
        {
            string name = "John";
            Console.WriteLine(nameof(name));
        }

        private void TypeNameSample()
        {
            string stringVal;
            Console.WriteLine(nameof(stringVal));
        }

        public void MemberNameTypeSample()
        {
            Console.WriteLine(nameof(MemberSampleClass.MyProperty));
            Console.WriteLine(nameof(MemberSampleClass.MyMethod));
        }

    }

    public abstract class MemberSampleClass
    {
        public int MyProperty { get; set; }
        public void MyMethod() { }
    }
}