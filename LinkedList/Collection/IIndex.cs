using System;
namespace LinkedList
{
    public interface IIndex<in T>
    {
        T this[int index] { get; }
    }
}
