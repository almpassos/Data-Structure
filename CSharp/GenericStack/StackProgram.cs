using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class StackProgram
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Display();
            Console.WriteLine("\nPushing Element into the stack: ");
            myStack.Push(14);
            myStack.Display();
            Console.WriteLine("\nPushing Element into the stack: ");
            myStack.Push(17);
            myStack.Display();

            Console.WriteLine("\nTop element of the stack: "+ myStack.Peek());

            Console.WriteLine("\nPushing Element into the stack: ");
            myStack.Push(18);
            myStack.Display();
            Console.WriteLine("\nPushing Element into the stack: ");
            myStack.Push(21);
            myStack.Display();

            Console.WriteLine("\nTop element of the stack: " + myStack.Peek());
            Console.WriteLine("\nStack size: " + myStack.Size());

            Console.WriteLine("\nSearching for 18: ");
            myStack.Search(18);
            Console.WriteLine("\nSearching for 15: ");
            myStack.Search(15);

            Console.WriteLine("\nPoping Element from the stack: ");
            myStack.Pop();
            myStack.Display();
            Console.WriteLine("\nPoping Element from the stack: ");
            myStack.Pop();
            myStack.Display();
            Console.WriteLine("\nPoping Element from the stack: ");
            myStack.Pop();
            myStack.Display();
            Console.WriteLine("\nPoping Element from the stack: ");
            myStack.Pop();
            myStack.Display();

            Console.ReadKey();


        }
    }
}
