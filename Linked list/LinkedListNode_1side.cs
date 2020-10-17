namespace Linked_list
{
    public class LinkedListNode_1side<T>
    {
        public T Data { get; set; }               
        public LinkedListNode_1side<T> Next { get; set; }
        public override string ToString()
        {
            if (Data == null)
                return "null";
            return Data.ToString();
        }
    }
}
