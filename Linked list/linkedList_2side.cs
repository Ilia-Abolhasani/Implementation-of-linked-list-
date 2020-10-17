using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list
{
    class linkedList_2side<T>
    {
        public int Count { get;  set; }
        private LinkedListNode_2side<T> Head;
        public void Add(T Data)
        {
            LinkedListNode_2side<T> New = new LinkedListNode_2side<T>() { Data = Data };
            if (Head == null)
                Head = New;
            else
            {
                var c = Head;
                while (c.Next != null)
                    c = c.Next;
                c.Next = New;
                New.Previous = c;
            }
            Count++;
        }
        public void Remove(T Data)
        {
            while (Head != null && Head.Data.Equals(Data))
            {
                Head = Head.Next;
                Head.Previous = null;
                Count--;
            }
            if (Head != null)
            {
                for (LinkedListNode_2side<T> c = Head; c.Next != null; )
                    if (c.Next.Data.Equals(Data))
                    {
                        c.Next = c.Next.Next;
                        c.Next.Previous = c;
                        Count--;
                    }
                    else
                        c = c.Next;
            }
        }
        public T At(int Index)
        {
            int Counter = 1;
            for (LinkedListNode_2side<T> c = Head; c != null; c = c.Next, Counter++)
                if (Counter == Index)
                    return c.Data;
            return default(T);
        }
        public void PrintAll()
        {
            Console.WriteLine("List:");
            for (int i = 0; i < Count; i++)
                Console.WriteLine(At(i));
        }    
    }
}
