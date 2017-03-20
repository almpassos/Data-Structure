using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    class QueueNode<T>
    {
        public T data { get; set; }

        public QueueNode<T> next { get; set; }

        public QueueNode(T dataValue, QueueNode<T> nextNode)
        {
            data = dataValue;
            next = nextNode;
        }

        public QueueNode(T dataValue) : this(dataValue,null) { }
    }
}
