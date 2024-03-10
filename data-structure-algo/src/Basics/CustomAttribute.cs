namespace data_structure_algo.src.Basics
{
    public class CustomAttribute : Attribute
    {
        public string Description { get; }

        public CustomAttribute(string Description)
        {
            this.Description = Description;
        }
    }

    [CustomAttribute("This is a CustomAttribute applied to a class")]
    public class CustomAttributeUsage
    {
        [CustomAttribute("This is a custom attribute applied to a method")]
        public void MyMethod()
        { }
    }
}