using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class ListNode<T>
    {
        public T data { get; set; }

        public ListNode<T> next { get; set; }
        
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            data = dataValue;
            next = nextNode;
        }

        public ListNode(T dataValue) : this(dataValue,null) { }
    }
}
