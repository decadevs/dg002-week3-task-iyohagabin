using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class SinglyLinkedList<T>
    {
        // Private fields
        private int count;

        // Constructor
        public SinglyLinkedList() ///hi
        {
            Head = null;
            count = 0;
        }

        // Public properties
        public int Count
        {
            get { return count; }
        }

        public Node<T> Head { get; set; }

        // Methods
        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
            return count;
        }

        public bool Remove(T item)
        {
            if (Head == null)
            {
                return false;
            }

            if (Head.Data.Equals(item))
            {
                Head = Head.Next;
                count--;
                return true;
            }

            Node<T> current = Head;
            while (current.Next != null && !current.Next.Data.Equals(item))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                count--;
                return true;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            Node<T> current = Head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
    }
}