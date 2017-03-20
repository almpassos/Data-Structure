using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class List <T> where T : IComparable
    {
        public ListNode<T> firstNode;
        public ListNode<T> lastNode;

        private T myData;

        public List() { }

        public List(T value)
        {
            myData = value;
            firstNode = null;
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void InsertAtFront(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                firstNode = new ListNode<T>(insertItem, firstNode);
            }
        }

        public void InsertAtBack(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                lastNode = lastNode.next = new ListNode<T>(insertItem);
            }
        }

        public T RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new Exception("The List is Empty");
            }

            T removeItem = firstNode.data;

            if(firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.next;
            }
            return removeItem;
        }

        public T RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new Exception("The List is Empty");
            }

            T removeItem = firstNode.data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode<T> current = firstNode;

                // loop while current.Next is not lastNode
                while (current.next != lastNode)
                {
                    current = current.next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.next = null;
            }

            return removeItem; // return removed data
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

                ListNode<T> current = firstNode;

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
            ListNode<T> current = firstNode;
            int position = 1;
            bool found = false;
            // output current node data while not at end of list
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data,value))
                {
                    found = true;
                    Console.WriteLine("Element found at position "+ position);
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

            ListNode<T> current = firstNode;

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
