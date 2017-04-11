using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    class TreeProgram
    {
        static void Main(string[] args)
        {

            Tree<int> myTree = new Tree<int>();

            for(int i=0; i<20; i++)
            {
                Random rand = new Random(i*DateTime.Now.Millisecond);
                myTree.InsertData(rand.Next(0, 99));
            }

            Console.WriteLine("Printing Tree in PreOrder");
            myTree.PreOrderPrint();
            Console.WriteLine("\n");
            Console.WriteLine("Printing Tree in InOrder");
            myTree.InOrderPrint();
            Console.WriteLine("\n");
            Console.WriteLine("Printing Tree in PostOrder");
            myTree.PostOrderPrint();

            Console.ReadKey();
        }
    }
}
