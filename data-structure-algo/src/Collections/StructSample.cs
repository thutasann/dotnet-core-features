namespace data_structure_algo.src.Collections
{
    /// <summary>
    /// Struct - A Struct is a composite data type that holds data
    /// that may consist of many different data types
    /// </summary>
    public struct StructSample
    {
        private string fName, mName, lName;

        public StructSample(string first, string middle, string last)
        {
            fName = first;
            mName = middle;
            lName = last;
        }

        public string FirstName
        {
            get { return fName; }
            set { fName = FirstName; }
        }

        public string MiddleName
        {
            get { return mName; }
            set { mName = MiddleName; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = LastName; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", fName, mName, lName);
        }

        public string Initials()
        {
            return String.Format("{0}{1}{2}", fName.Substring(0, 1), mName.Substring(0, 1), lName.Substring(0, 1));
        }

    }
}