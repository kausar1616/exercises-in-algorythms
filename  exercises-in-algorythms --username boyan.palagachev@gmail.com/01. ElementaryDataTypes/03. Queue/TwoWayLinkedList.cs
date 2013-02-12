using System;

namespace TwoWayLinkedList
{
    // DataType - genenric
    // pointer to the next Node
    internal class TwoWayNode<T>
    {
        private T value;
        private TwoWayNode<T> next;
        private TwoWayNode<T> previous;
        // Construnctor for head/z
        public TwoWayNode()
        {
            //this.value = null;
        }
        // Construnctor for elements
        public TwoWayNode(T Value)
        {
            this.value = Value;
        }
        // Properies - pointer and values
        public TwoWayNode<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public TwoWayNode<T> Previous
        {
            get { return this.previous; }
            set { this.previous = value; }
        }
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

    }
    // LinkedList of Node
    // provides functionality
    internal class TwoWayLinkedList<K>
    {
        // stores a head and a z
        private TwoWayNode<K> head;
        private TwoWayNode<K> tail;

        // Constructor initialize by creating head and z
        public TwoWayLinkedList()
        {
            head = new TwoWayNode<K>();
            tail = new TwoWayNode<K>();
            head.Previous = head;
            tail.Next = tail;

            head.Next = tail;
            tail.Previous = head;

        }

        // proparties
        public bool IsEmply
        {
            get
            {
                if (this.head.Next == this.tail)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public TwoWayNode<K> Head
        {
            get { return this.head; }
        }
        public TwoWayNode<K> Tail
        {
            get { return this.tail; }
        }

        // delete next
        // if try to delete the last one it would delete the first one
        public void DeleteNext(TwoWayNode<K> a)
        {
            if (a.Next == a.Next.Next)
            {
                head.Next = head.Next.Next;
            }
            else
            {
                a.Next = a.Next.Next;
            }

        }
        public void DeletePrevious(TwoWayNode<K> a)
        {
            if (a.Previous == a.Previous.Previous)
            {
                tail.Previous = tail.Previous.Previous;
            }
            else
            {
                a.Previous = a.Previous.Previous;
            }

        }
        // insert after
        public void InsertAfter(TwoWayNode<K> a, K value)
        {
            TwoWayNode<K> newNode = new TwoWayNode<K>(value);
            newNode.Next = a.Next;
            newNode.Previous = a;
            newNode.Next.Previous = newNode;
            a.Next = newNode;
        }

        public void InsertBefore(TwoWayNode<K> a, K value)
        {
            TwoWayNode<K> newNode = new TwoWayNode<K>(value);
            newNode.Previous = a.Previous;
            newNode.Next = a;
            newNode.Previous.Next = newNode;
            a.Previous = newNode;
        }
        // fetchs the next node after the argument
        public TwoWayNode<K> GetNext(TwoWayNode<K> currentNode)
        {

            if (currentNode.Next.Next == currentNode.Next)
            {
                return Head.Next;
            }
            else
            {
                return currentNode.Next;
            }

        }
        public TwoWayNode<K> GetPrevious(TwoWayNode<K> currentNode)
        {

            if (currentNode.Previous.Previous == currentNode.Previous)
            {
                return Tail.Previous;
            }
            else
            {
                return currentNode.Previous;
            }

        }


    }
}
