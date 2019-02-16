using System;

namespace LuKaSo.Sort
{
    public interface ISorter<T> where T : IComparable<T>
    {
        T[] Sort(T[] array);
    }
}
