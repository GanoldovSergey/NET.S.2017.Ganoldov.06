using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class BubbleSort
    {
        /// <summary>
        /// Method for sorting jugged arrays
        /// </summary>
        /// <param name="array">Array to be sorted </param>
        /// <param name="comparer"></param>
        public static void Sort(int[][] array, IComparer<int[]> comparer)
        {
            CheckValidArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) > 0)
                        Swap(ref array[i], ref array[j]);
                }
            }
        }

        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            int[] temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private static void CheckValidArray(int[][] array)
        {
            if (ReferenceEquals(array, null)) throw new ArgumentNullException($"{nameof(array)} is null");

            for (int i = 0; i < array.Length; i++)
            {
                if (ReferenceEquals(array[i], null))
                    throw new ArgumentNullException($"{nameof(array)}[{i}] is null");
            }
        }
    }
}
