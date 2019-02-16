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
    }
}
