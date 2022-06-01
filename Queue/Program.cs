using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(50);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dqueue();
            queue.Dqueue();
            queue.Dqueue();
            queue.Display();
        }
    }
}
