namespace LuKaSo.Sort
{
    public static class SortHelpers
    {
        public static void Swap<T>(T[] array, uint from, uint to)
        {
            var temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
}
