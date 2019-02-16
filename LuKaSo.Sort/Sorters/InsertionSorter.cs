using LuKaSo.Sort.Common;
using System;

namespace LuKaSo.Sort.Sorters
{
    /// <summary>
    /// Insertion sorter, implementation of insertion sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertionSorter<T> : ISorter<T>
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
                Sort(array, 1);
            }

            return array;
        }

        /// <summary>
        /// Insertion sort algorithm
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sortedItems"></param>
        private void Sort(T[] array, int sortedItems)
        {
            if (array.Length - 1 < sortedItems)
            {
                return;
            }

            for (int i = sortedItems-1; i >= 0; i--)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    SorterHelpers.Swap(array, (uint)i, (uint)i + 1);
                }
            }

            Sort(array, sortedItems + 1);
        }
    }
}
