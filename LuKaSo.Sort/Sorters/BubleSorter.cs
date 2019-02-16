using LuKaSo.Sort.Common;
using System;

namespace LuKaSo.Sort.Sorters
{
    /// <summary>
    /// Buble sorter, implementation of buble sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubleSorter<T> : ISorter<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Sort
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public T[] Sort(T[] array)
        {
            if (array.Length > 1)
            {
                Sort(array, (uint)array.Length - 1);
            }

            return array;
        }

        /// <summary>
        /// Buble sort algorithm
        /// </summary>
        /// <param name="array"></param>
        /// <param name="iteration"></param>
        /// <returns></returns>
        public void Sort(T[] array, uint iteration)
        {
            if (iteration < 1)
            {
                return;
            }

            for (uint i = 0; i < iteration; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    SorterHelpers.Swap(array, i, i + 1);
                }
            }

            Sort(array, iteration - 1);
        }
    }
}
