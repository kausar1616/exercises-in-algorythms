using System;
using TwoWayLinkedList;

namespace MyQueue
{
    internal class Queue<K>
    {
        private TwoWayLinkedList<K> queue;
        public Queue()
        {
            queue = new TwoWayLinkedList<K>();
        }
        public void Insert(K value)
        {
            //TwoWayNode<K> valueToInsert = new TwoWayNode<K>(value);
            this.queue.InsertAfter(this.queue.Head, value);
        }
        public K Remove()
        {
            if (queue.IsEmply)
            {
                throw new InvalidOperationException("You cant remove items from empty queue!");
            }
            TwoWayNode<K> current = this.queue.GetPrevious(this.queue.Tail);
            queue.DeletePrevious(queue.Tail);
            return current.Value;


        }
    }
}
