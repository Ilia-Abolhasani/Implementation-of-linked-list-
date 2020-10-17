using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list
{
    class LinkedListNode_2side<T>
    {
        public T Data { get; set; }        
        public LinkedListNode_2side<T> Previous{ get; set; }
        public LinkedListNode_2side<T> Next{ get; set; }
        public override string ToString()
        {
            if (Data == null)
                return "null";
            return Data.ToString();
        }

    }
}
