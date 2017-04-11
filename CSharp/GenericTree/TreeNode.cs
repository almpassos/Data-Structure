using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    class TreeNode<T> where T : IComparable
    {
        public T data { get; set; }

        public TreeNode<T> leftNode { get; set; }

        public TreeNode<T> rightNode { get; set; }

        public TreeNode(T myData)
        {
            data = myData;
        }

        public void Insert(T newData)
        {
            if (newData.CompareTo(data) < 0)
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode<T>(newData);
                }
                else
                {
                    leftNode.Insert(newData);
                }
            }else if(newData.CompareTo(data) > 0)
            {
                if(rightNode == null)
                {
                    rightNode = new TreeNode<T>(newData);
                }else
                {
                    rightNode.Insert(newData);
                }
            }
        }
    }
}
