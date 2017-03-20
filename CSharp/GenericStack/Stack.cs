using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class Stack<T> where T : IComparable
    {
        public StackNode<T> firstNode;
        public StackNode<T> lastNode;

        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void Push(T dataValue)
        {
            if(IsEmpty())
            {
                firstNode = lastNode = new StackNode<T>(dataValue);
            }
            else
            {
                firstNode = new StackNode<T>(dataValue, firstNode);
            }
        }

        // remove item from top of stack by removing
        // item at front of linked list
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }

            T removeItem = firstNode.data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.next;
            }
            return removeItem;
        }

        public T Peek()
        {
            return firstNode.data;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                //throw new Exception("The Stack is Empty");
                Console.WriteLine("Empty -- Nothing to show\n");
            }
            else
            {
                Console.Write("Elements stored: ");

                StackNode<T> current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.data} ");
                    current = current.next;
                }

                Console.WriteLine("\n");
            }
        }

        public void Search(T value)
        {
            StackNode<T> current = firstNode;
            int position = 1;
            bool found = false;
            // output current node data while not at end of list
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, value))
                {
                    found = true;
                    Console.WriteLine("Element found at position " + position);
                }
                current = current.next;
                position = position + 1;
            }
            if (found == false)
            {
                Console.WriteLine("Element not found");
            }
        }

        public int Size()
        {
            int count = 0;

            StackNode<T> current = firstNode;

            // output current node data while not at end of list
            while (current != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

    }
}
