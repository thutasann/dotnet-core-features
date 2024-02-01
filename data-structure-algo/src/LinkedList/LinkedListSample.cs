using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structure_algo.src.LinkedList
{
    /// <summary>
    /// Linked List Sample
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