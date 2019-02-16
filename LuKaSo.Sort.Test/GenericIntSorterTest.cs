using LuKaSo.Sort.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LuKaSo.Sort.Test
{
    [TestClass]
    public abstract class GenericIntSorterTest<T>
        where T : ISorter<int>, new()
    {
        [TestMethod]
        public void TestEmty()
        {
            var sorter = new T();
            int[] array = new int[0];
            sorter.Sort(array);

            Assert.AreEqual(array.Length, 0);
        }

        [TestMethod]
        public void TestOne()
        {
            var sorter = new T();
            int[] array = new int[] { 1 };
            sorter.Sort(array);

            Assert.AreEqual(array.Length, 1);
            Assert.AreEqual(array[0], 1);
        }

        [TestMethod]
        public void TestSorted()
        {
            var sorter = new T();
            int[] arrayOriginal = new int[] { 1, 2, 3, 4 };
            int[] array = new int[arrayOriginal.Length];
            arrayOriginal.CopyTo(array, 0);

            sorter.Sort(array);

            Assert.AreEqual(array.Length, arrayOriginal.Length);
            Assert.IsTrue(Enumerable.SequenceEqual(arrayOriginal, array));
        }

        [TestMethod]
        public void TestUnSorted()
        {
            var sorter = new T();
            int[] arrayOriginal = new int[] { 100, 2, 30, 4, 5, 6, 77, 14, 15, 56, 80, 11, 1, 8, 32 };
            int[] array = new int[arrayOriginal.Length];
            arrayOriginal.CopyTo(array, 0);

            sorter.Sort(array);

            Assert.AreEqual(array.Length, arrayOriginal.Length);

            Array.Sort(arrayOriginal);
            Assert.IsTrue(Enumerable.SequenceEqual(arrayOriginal, array));
        }

        [TestMethod]
        public void TestUnSortedMultiple()
        {
            var sorter = new T();
            int[] arrayOriginal = new int[] { 100, 2, 2, 4, 4, 6, 77, 14, 77, 56, 80, 11, 77, 8, 32 };
            int[] array = new int[arrayOriginal.Length];
            arrayOriginal.CopyTo(array, 0);

            sorter.Sort(array);

            Assert.AreEqual(array.Length, arrayOriginal.Length);

            Array.Sort(arrayOriginal);
            Assert.IsTrue(Enumerable.SequenceEqual(arrayOriginal, array));
        }

        [TestMethod]
        public void TestRandom()
        {
            var sorter = new T();
            int[] arrayOriginal = new int[100];
            int[] array = new int[arrayOriginal.Length];
            var random = new Random();

            for (int i = 0; i < arrayOriginal.Length - 1; i++)
            {
                arrayOriginal[i] = random.Next(0, 100);
            }

            arrayOriginal.CopyTo(array, 0);

            sorter.Sort(array);

            Assert.AreEqual(array.Length, arrayOriginal.Length);

            Array.Sort(arrayOriginal);
            Assert.IsTrue(Enumerable.SequenceEqual(arrayOriginal, array));
        }
    }
}
