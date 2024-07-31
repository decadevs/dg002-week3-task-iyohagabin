namespace DG002_Week3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Test SinglyLinkedList
            var linkedList = new SinglyLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            Console.WriteLine("LinkedList Size: " + linkedList.Count);

            linkedList.Remove(2);
            Console.WriteLine("LinkedList Contains 2: " + linkedList.Check(2));

            // Test Stack
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack Size: " + stack.Size());

            Console.WriteLine("Stack Pop: " + stack.Pop());

            // Test Queue
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Queue Size: " + queue.Size());

            Console.WriteLine("Queue Dequeue: " + queue.Dequeue());
        }
    }
}
