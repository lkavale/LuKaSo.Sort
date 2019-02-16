using System;

namespace LuKaSo.Sort
{
    public class QuickSort<T> : ISorter<T> where T : IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            if (array.Length > 1)
            {
                Sort(array, 0, (uint)array.Length - 1);
            }

            return array;
        }

        private void Sort(T[] array, uint start, uint end)
        {
            if (end <= start)
            {
                return;
            }

            var pivotPosition = end;
            var pivot = array[pivotPosition];

            for (uint i = start; i <= pivotPosition; i++)
            {
                if (array[i].CompareTo(pivot) > 0)
                {
                    SortHelpers.Swap(array, pivotPosition - 1, pivotPosition);

                    if (i < pivotPosition - 1)
                    {
                        SortHelpers.Swap(array, pivotPosition, i);
                        i--;
                    }

                    pivotPosition--;
                }
            }

            Sort(array, start, pivotPosition - 1);
            Sort(array, pivotPosition + 1, end);
        }
    }
}