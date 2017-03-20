using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class StackNode<T>
    {
        public T data { get; set; }

        public StackNode<T> next { get; set; }

        public StackNode(T dataValue, StackNode<T> nextNode)
        {
            data = dataValue;
            next = nextNode;
        }

        public StackNode(T dataValue) : this(dataValue,null) { }
    }
}
