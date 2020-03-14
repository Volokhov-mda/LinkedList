using System;
namespace LinkedList
{
    public class LinkedList<T> : ICollection<T>
    {
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }

        public int Size { get; private set; }

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>(item);
            }
            else
            {
                Node<T> newNode = new Node<T>(item, Tail);
                Tail.Next = newNode;
                Tail = newNode;
            }

            ++Size;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public LinkedList()
        {
        }
    }
}
