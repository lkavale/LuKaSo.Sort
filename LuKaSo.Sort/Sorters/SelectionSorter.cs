using LuKaSo.Sort.Common;
using System;

namespace LuKaSo.Sort.Sorters
{
    /// <summary>
    /// Selection sorter, implementation of selection sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
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
                Sort(array, 0);
            }

            return array;
        }

        /// <summary>
        /// Selection sort algorithm
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sortedItems"></param>
        private void Sort(T[] array, uint sortedItems)
        {
            for (uint i = sortedItems; i < array.Length; i++)
            {
                var position = SorterHelpers.PositionOfMinimum(array, i, (uint)array.Length);
                SorterHelpers.Swap(array, i, position);
            }
        }
    }
}
