namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// # Protected Keyword <br/>
    /// - an access modifier used to restrict access to members (fields, properties, methods, and nested types) of a class to derived classes <br/>
    /// ## Access to Derived Classes: <br/>
    /// - Members declared as protected can be accessed by derived classes (i.e., classes that inherit from the class where the member is declared). <br/>
    /// - This allows derived classes to access and modify the protected members. <br/>
    /// ## Restriction to Other Classes: <br/>
    /// - Unlike public members, protected members are not accessible to code outside the class or its derived classes. They are encapsulated within the class hierarchy. <br/>
    /// </summary>
    public class ProtectedSample
    {
    }

    public class BaseClass
    {
        protected int protectedField;
        protected void ProtectedMethod()
        {
            // can be access by derived class
        }
    }

    public class DerivedClass : BaseClass
    {
        public void AccessProtectedMember()
        {
            protectedField = 10;
            ProtectedMethod();
        }
    }
}