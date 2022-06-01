using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack llStack = new LinkedListStack();
            llStack.Push(56);
            llStack.Push(30);
            llStack.Push(70);
            llStack.Display();
            llStack.peek();
            llStack.pop();
            Console.WriteLine(" \n\n### After Pop operation ###  ");
            llStack.Display();
            llStack.IsEmpty();

        }
    }
}
