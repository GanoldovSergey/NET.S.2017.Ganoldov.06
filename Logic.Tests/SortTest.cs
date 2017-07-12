using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Logic.Tests
{
    public class SortTest
    {
        [TestCase(ExpectedResult = true)]
        public int[][] Sort_IncreaseSum()
        {
            int[][] arr = { new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 } };
            IncreaseSum comparer = new IncreaseSum();
            BubbleSort.Sort(arr, comparer);
            return arr;
        }

        [TestCase(ExpectedResult = true)]
        public int[][] Sort_DecreaseSum()
        {
            int[][] arr = { new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 } };
            DecreaseSum comparer = new DecreaseSum();
            BubbleSort.Sort(arr, comparer);
            return arr;
        }

        [TestCase(ExpectedResult = true)]
        public int[][] Sort_IncreaseMax()
        {
            int[][] arr = { new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 } };
            IncreaseMax comparer = new IncreaseMax();
            BubbleSort.Sort(arr, comparer);
            return arr;
        }

        [TestCase(ExpectedResult = true)]
        public int[][] Sort_DecreaseMax()
        {
            int[][] arr = { new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 } };
            DecreaseMax comparer = new DecreaseMax();
            BubbleSort.Sort(arr, comparer);
            return arr;
        }

        [TestCase(ExpectedResult = true)]
        public int[][] Sort_IncreaseMin()
        {
            int[][] arr = { new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 } };
            IncreaseMin comparer = new IncreaseMin();
            BubbleSort.Sort(arr, comparer);
            return arr;
        }

        [TestCase(ExpectedResult = true)]
        public int[][] Sort_DecreaseMin()
        {
            int[][] arr = { new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 } };
            DecreaseMin comparer = new DecreaseMin();
            BubbleSort.Sort(arr, comparer);
            return arr;
        }


        private class IncreaseSum : IComparer<int[]>
        {
            public int Compare(int[] lhs, int[] rhs) => lhs.Sum() - rhs.Sum();
        }
        private class DecreaseSum : IComparer<int[]>
        {
            public int Compare(int[] lhs, int[] rhs) => rhs.Sum() - lhs.Sum();
        }
        private class IncreaseMax : IComparer<int[]>
        {
            public int Compare(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
        }
        private class DecreaseMax : IComparer<int[]>
        {
            public int Compare(int[] lhs, int[] rhs) => rhs.Max() - lhs.Max();
        }
        private class IncreaseMin : IComparer<int[]>
        {
            public int Compare(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
        }
        private class DecreaseMin : IComparer<int[]>
        {
            public int Compare(int[] lhs, int[] rhs) => rhs.Min() - lhs.Min();
        }
    }
}