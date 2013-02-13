using System;
using MyLinkedList;

namespace MyStack
{
    internal class MyStack<K>
    {
        private MyLinkedList<K> stack;

        // Constructor - Initialies Stack
        public MyStack()
        {
            stack = new MyLinkedList<K>();
        }

        public bool IsEmpty
        {
            get 
            {
                if (this.stack.Head.Next == this.stack.Head.Next.Next)
                {
                    return true;
                }
                return false;
            }
        }
        public void Push(K value)
        {
            Node<K> valueToPush = new Node<K>(value);
            valueToPush.Next = stack.Head.Next;
            stack.Head.Next = valueToPush;
        }
        public K Pop()
        {
            Node<K> toPop = new Node<K>();
            toPop = stack.Head.Next;
            stack.Head.Next = stack.Head.Next.Next;
            return toPop.Value;

        }
    }

}
