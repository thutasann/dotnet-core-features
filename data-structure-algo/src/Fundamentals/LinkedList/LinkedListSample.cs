namespace data_structure_algo.src.LinkedList
{
    /// <summary>
    ///Linked List is a linear data structure which consists of a group of nodes in a sequence. Each node contains two parts. <br/>
    ///- Data <br/>
    ///- Address <br/>
    /// Source - https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListSample<T>
    {
        public T Data { get; set; }

        /// <summary>
        /// Link is the pointer to the node <br/>
        /// to which this instance will be connected.
        /// </summary>
        public LinkedListSample<T> Link { get; set; }

        public LinkedListSample(T Data, LinkedListSample<T> Link)
        {
            this.Data = Data;
            this.Link = Link;
        }
    }
}