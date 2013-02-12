using System;

namespace MyLinkedList
{
    // DataType - genenric
    // pointer to the next Node
    internal class Node<T>
    {
        private T value;
        private Node<T> next;
        // Construnctor for head/z
        public Node()
        {
            //this.value = null;
        }
        // Construnctor for elements
        public Node(T Value)
        {
            this.value = Value;
        }
        // Properies - pointer and values
        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

    }
    // LinkedList of Node
    // provides functionality
    internal class MyLinkedList<K>
    {
        // stores a head and a z
        private Node<K> head;
        private Node<K> z;

        // Constructor initialize by creating head and z
        public MyLinkedList()
        {
            head = new Node<K>();
            z = new Node<K>();
            head.Next = z;
            z.Next = z;

        }

        // proparties
        public bool IsEmply
        {
            get
            {
                if (this.head.Next == this.z)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Node<K> Head
        {
            get { return this.head; }
        }

        // delete next
        // if try to delete the last one it would delete the first one
        public void DeleteNext(Node<K> a)
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
        // insert after
        public void InsertAfter(Node<K> a, K value)
        {
            Node<K> newNode = new Node<K>(value);
            newNode.Next = a.Next;
            a.Next = newNode;
        }
        // fetchs the next node after the argument
        public Node<K> GetNext(Node<K> currentNode)
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


    }
}
