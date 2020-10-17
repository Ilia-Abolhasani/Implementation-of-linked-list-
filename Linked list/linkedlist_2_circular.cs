using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list
{
    class linkedlist_2_circular<T>
    {
        public int Count { get; set; }
        private LinkedListNode_2side<T> Head;
        public void Add(T Data)
        {
            LinkedListNode_2side<T> New = new LinkedListNode_2side<T>() { Data = Data };
            if (Head == null)
            {
                Head = New;
                Head.Next = Head;
                Head.Previous = Head;
            }
            else
            {
                New.Next = Head;                
                New.Previous = Head.Previous;
                Head.Previous.Next = New;
                Head.Previous = New;
            }
            Count++;
        }
        public void Remove(T Data)
        {
            while (Head != null && Head.Data.Equals(Data))
            {
                if (Count == 1)
                    Head = null;
                else
                {
                    Head.Previous.Next = Head.Next;
                    Head.Next.Previous = Head.Previous;
                    Head = Head.Next;
                } 
                Count--;
            }
            if (Head != null)
            {
                for (LinkedListNode_2side<T> c = Head; c.Next != Head; )
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
            if (Index == 1)
                return Head.Data;
            int Counter = 2;
            for (LinkedListNode_2side<T> c = Head.Next ; c != Head; c = c.Next, Counter++)
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
