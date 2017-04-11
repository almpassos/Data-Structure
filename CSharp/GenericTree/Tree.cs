using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    class Tree<T> where T : IComparable
    {
        private TreeNode<T> root; 


        public void InsertData(T value)
        {
            if(root == null)
            {
                root = new TreeNode<T>(value);
            }else
            {
                root.Insert(value);
            }
        }

        public void PreOrderPrint()
        {
            PreOrder(root);
        }

        private void PreOrder(TreeNode<T> node)
        {
            if(node != null)
            {
                Console.Write($"{node.data} ");
                PreOrder(node.leftNode);
                PreOrder(node.rightNode);
            }
        }

        public void InOrderPrint()
        {
            InOrder(root);
        }

        private void InOrder(TreeNode<T> node)
        {
            if (node != null)
            {
                InOrder(node.leftNode);

                Console.Write($"{node.data} ");
                
                InOrder(node.rightNode);
            }
        }

        public void PostOrderPrint()
        {
            PostOrder(root);
        }

        private void PostOrder(TreeNode<T> node)
        {
            if (node != null)
            {
                InOrder(node.leftNode);

                InOrder(node.rightNode);

                Console.Write($"{node.data} ");
                
            }
        }

    }
}
