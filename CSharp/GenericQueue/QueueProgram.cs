using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    class QueueProgram
    {
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();

            Console.WriteLine("Puting 14 into the Queue");
            queue.Enqueue(14);
            queue.Display();
            Console.WriteLine("Puting 17 into the Queue");
            queue.Enqueue(17);
            queue.Display();
            Console.WriteLine("Puting 18 into the Queue");
            queue.Enqueue(18);
            queue.Display();
            Console.WriteLine("Puting 21 into the Queue");
            queue.Enqueue(21);
            queue.Display();

            Console.WriteLine();

            Console.WriteLine("Removing a element from the Queue");
            queue.Dequeue();
            queue.Display();
            Console.WriteLine("Removing a element from the Queue");
            queue.Dequeue();
            queue.Display();
            Console.WriteLine("Removing a element from the Queue");
            queue.Dequeue();
            queue.Display();
            Console.WriteLine("Removing a element from the Queue");
            queue.Dequeue();
            queue.Display();

            Console.ReadKey();

        }
    }
}
