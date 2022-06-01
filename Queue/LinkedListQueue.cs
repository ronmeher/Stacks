using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class LinkedListQueue
    {
        Node head = null;

        internal void Enqueue(int value)
        {
            Node node = new Node(value);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }

        internal void Display()
        {
            Console.WriteLine("\n\n  ----- Displaying Element in Queue ------\n");
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void Dqueue()
        {
            if(this.head == null)
            {
                Console.WriteLine("Queue is empty Deletion is not possible");
            }
            else
            {
                Console.WriteLine("Value Dequeued is {0} ", this.head.data);
                this.head = this.head.next;
            }
        }
    }
}
