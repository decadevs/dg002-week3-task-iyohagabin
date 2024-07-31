using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Queue<T> //First in, First out (FIFO)
    {
        private SinglyLinkedList<T> list = new SinglyLinkedList<T>();

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var headData = list.Head.Data;
            list.Remove(headData);
            return headData;
        }

        public int Size()
        {
            return list.Count;
        }
    }
}
