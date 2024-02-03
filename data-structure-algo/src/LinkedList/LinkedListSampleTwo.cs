namespace data_structure_algo.src.LinkedList
{
    /// <summary>
    /// Singly Linked List <br/>
    /// The node of a singly linked list contains a data part and a link part <br/>
    ///  The link will contain the address of next node and is initialized to null
    /// </summary>
    internal class Node
    {
        internal int data;
        internal required Node? next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    /// <summary>
    /// Doubley Linked List <br/>
    /// The node for a Doubly Linked list will contain one data part and two link parts - previous link and next link. 
    /// </summary>
    internal class DNode
    {
        internal int data;
        internal required DNode? prev;
        internal required DNode? next;

        public DNode(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
    }


    /// <summary>
    /// Single LinkedList -> Head is null;
    /// </summary>
    internal class SingleLinkedList
    {
        internal required Node head;
    }

    /// <summary>
    /// Double Linked List
    /// </summary>
    internal class DoubleLinkedList
    {
        internal required DNode head;
    }

    public class LinkedListSampleTwo
    {
        /// <summary>
        /// Insert Data at the front of the Singly Linked List
        /// </summary>
        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new(new_data)
            {
                next = singlyList.head
            };
            singlyList.head = new_node;
        }

        /// <summary>
        /// Insert Data at the Front of the Double Linked List
        /// </summary>
        internal void InsertFrontDouble(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new(data)
            {
                next = doubleLinkedList.head,
                prev = null
            };

            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }
    }

}