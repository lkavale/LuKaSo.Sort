using LuKaSo.Sort.Common;
using System;

namespace LuKaSo.Sort.Sorters
{
    /// <summary>
    /// Quick sorter, implementation of quick sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSorter<T> : ISorter<T>
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
        /// Quick sort algorithm
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void Sort(T[] array, uint start, uint end)
        {
            // Only one item, nothing to sort
            if (end <= start)
            {
                return;
            }

            var pivotPosition = end;
            var pivot = array[pivotPosition];

            // Sorting by pivot
            for (uint i = start; i <= pivotPosition; i++)
            {
                if (array[i].CompareTo(pivot) > 0)
                {
                    SorterHelpers.Swap(array, pivotPosition - 1, pivotPosition);

                    if (i < pivotPosition - 1)
                    {
                        SorterHelpers.Swap(array, pivotPosition, i);
                        i--;
                    }

                    pivotPosition--;
                }
            }

            // Sort part before and after pivot
            Sort(array, start, pivotPosition - 1);
            Sort(array, pivotPosition + 1, end);
        }
    }
}