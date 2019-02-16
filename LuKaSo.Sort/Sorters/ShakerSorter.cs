using LuKaSo.Sort.Common;
using System;

namespace LuKaSo.Sort.Sorters
{
    /// <summary>
    /// Shaker sorter, implementation of shaker sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShakerSorter<T> : ISorter<T>
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
                Sort(array, 0, (uint)array.Length - 1);
            }

            return array;
        }

        /// <summary>
        /// Shaker sort algorithm
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void Sort(T[] array, uint start, uint end)
        {
            for (uint i = start; i < end; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    SorterHelpers.Swap(array, i, i + 1);
                }
            }

            end--;

            if (start == end)
            {
                return;
            }

            for (uint i = end; i > start; i--)
            {
                if (array[i].CompareTo(array[i - 1]) < 0)
                {
                    SorterHelpers.Swap(array, i - 1, i);
                }
            }

            start++;

            if (start == end)
            {
                return;
            }

            Sort(array, start, end);
        }
    }
}
