using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Node<T>
    {
        // Constructor
        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        // Public properties
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
