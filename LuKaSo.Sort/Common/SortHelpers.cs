using System;

namespace LuKaSo.Sort.Common
{
    /// <summary>
    /// Sorter helpers
    /// </summary>
    public static class SorterHelpers
    {
        /// <summary>
        /// Swap two items in array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void Swap<T>(T[] array, uint from, uint to)
        {
            var temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }

        /// <summary>
        /// Find position of minimum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static uint PositionOfMinimum<T>(T[] array, uint from, uint to) where T : IComparable<T>
        {
            var position = from;

            for (uint i = from + 1; i < to; i++)
            {
                if (array[i].CompareTo(array[position]) < 0)
                {
                    position = i;
                }
            }

            return position;
        }
    }
}
