using System;

namespace LuKaSo.Sort.Common
{
    /// <summary>
    /// Sorter interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sort
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        T[] Sort(T[] array);
    }
}
