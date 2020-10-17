using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list
{
    class linkedlist_1_circular<T>
    {        
        public int Count { get; set; }
        private LinkedListNode_1side<T> Head;                        
        public void Add(T Data)
        {
            LinkedListNode_1side<T> New = new LinkedListNode_1side<T>() { Data = Data };
            if (Head == null)
            {
                Head = New;
                Head.Next = Head;
            }
            else
            {
                var c = Head;
                while (c.Next != Head)
                    c = c.Next;
                c.Next = New;
                New.Next = Head;                
            }
            Count++;
        }
        public void Remove(T Data)
        {
            while (Head != null && Head.Data.Equals(Data))
            {
                if (Count==1)
                    Head = null;
                LinkedListNode_1side<T> c = Head;
                while (c.Next != Head)
                    c = c.Next;    
                Head = Head.Next;
                c.Next = Head;
                Count--;
            }
            if (Head != null&&Count!=1)
            {
                for (LinkedListNode_1side<T> c = Head; c.Next !=Head; )
                    if (c.Next.Data.Equals(Data))
                    {
                        c.Next = c.Next.Next;
                        Count--;
                    }
                    else
                        c = c.Next;
            }                  
        }
        public T At(int Index)
        {
            if (Index == 1)
                return Head.Data;
            int Counter = 2;
            for (LinkedListNode_1side<T> c = Head.Next; c !=Head ; c = c.Next, Counter++)
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
