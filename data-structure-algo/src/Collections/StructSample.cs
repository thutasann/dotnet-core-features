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
            readonly get { return fName; }
            set { fName = FirstName; }
        }

        public string MiddleName
        {
            readonly get { return mName; }
            set { mName = MiddleName; }
        }

        public string LastName
        {
            readonly get { return lName; }
            set { lName = LastName; }
        }

        public override readonly string ToString()
        {
            return string.Format("{0} {1} {2}", fName, mName, lName);
        }

        public readonly string Initials()
        {
            return string.Format("{0}{1}{2}", fName[..1], mName[..1], lName[..1]);
        }

    }
}