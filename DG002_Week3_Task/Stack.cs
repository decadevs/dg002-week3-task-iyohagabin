using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Stack<T>  //Stack operations LIFO(last in first out)
    {
        private SinglyLinkedList<T> list = new SinglyLinkedList<T>();

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var current = list.Head;
            T lastData = default(T);
            while (current.Next != null)
            {
                current = current.Next;
            }
            lastData = current.Data;
            list.Remove(lastData);
            return lastData;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var current = list.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int Size()
        {
            return list.Count;
        }
    }
}