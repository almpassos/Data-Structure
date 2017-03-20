using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    class Queue<T>
    {
        public QueueNode<T> firstNode;
        public QueueNode<T> lastNode;

        private T myData;

        public Queue() { }

        public Queue(T value)
        {
            myData = value;
            firstNode = null;
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void Enqueue(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new QueueNode<T>(insertItem);
            }
            else
            {
                lastNode = lastNode.next = new QueueNode<T>(insertItem);
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("The Queue is Empty");
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

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                //throw new Exception("The List is Empty");
                Console.WriteLine("Empty -- Nothing to show\n");
            }
            else
            {
                Console.Write("Elements stored: ");

                QueueNode<T> current = firstNode;

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
            QueueNode<T> current = firstNode;
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

            QueueNode<T> current = firstNode;

            // output current node data while not at end of list
            while (current != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

        public static implicit operator Queue<T>(Queue<int> v)
        {
            throw new NotImplementedException();
        }
    }
}
