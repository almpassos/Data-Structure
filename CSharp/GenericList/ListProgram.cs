using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class ListProgram
    {
        static void Main(string[] args)
        {
            try
            {
                var myList = new List<int>();

                Console.WriteLine("Inserting element at front: ");
                myList.InsertAtFront(18);
                myList.Display();
                Console.WriteLine("Inserting element at front: ");
                myList.InsertAtFront(17);
                myList.Display();
                Console.WriteLine("Inserting element at back: ");
                myList.InsertAtBack(14);
                myList.Display();
                Console.WriteLine("Inserting element at back: ");
                myList.InsertAtBack(21);
                myList.Display();

                Console.WriteLine("Counting elements: ");
                Console.WriteLine(myList.Size() + " elements in this list \n");

                Console.WriteLine("Searching element: 21 ");
                myList.Search(21);
                myList.Display();
                Console.WriteLine("Searching element: 12 ");
                myList.Search(12);
                myList.Display();

                Console.WriteLine("Removing Element from the Front: ");
                object removedObject = myList.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                myList.Display();

                Console.WriteLine("Removing Element from the Front: ");
                removedObject = myList.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                myList.Display();

                Console.WriteLine("Removing Element from the Back: ");
                removedObject = myList.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                myList.Display();

                Console.WriteLine("Removing Element from the Back: ");
                removedObject = myList.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed\n");
                myList.Display();

                Console.WriteLine("Counting elements: ");
                Console.WriteLine(myList.Size() + " elements in this list\n");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"\n {ex} ");
            }


        }
    }
}
