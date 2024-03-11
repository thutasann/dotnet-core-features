namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// # Private keyword <br/>
    /// - Members declared as private are accessible only within the containing class or struct. <br/>
    /// - They are not accessible from outside the class, including derived classes. <br/>
    /// </summary>
    public class PrivateSample
    {
        private int privateField;
        private void PrivateMethod()
        {
            // Accessible only withing this class
        }
    }


    /// <summary>
    /// - Use private when you want to restrict access to a member strictly within the containing class.
    /// - Use protected when you want to allow derived classes to access and inherit members, while still restricting access from outside the class hierarchy.
    /// </summary>
    public class PrivateVsProtected { }
}