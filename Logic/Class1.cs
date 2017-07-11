using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class BubbleSort
    {
        public static void Sort(int[][] array, Comparison<int[]> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparison(array[i], array[j]) > 0)
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


        public static int IncreaseSumComp(int[] lhs, int[] rhs) => lhs.Sum() - rhs.Sum();
        private static int DecreaseSumComp(int[] lhs, int[] rhs) => IncreaseSumComp(rhs, lhs);
        private static int IncreaseMaxComp(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
        private static int DecreaseMaxComp(int[] lhs, int[] rhs) => IncreaseMaxComp(rhs, lhs);
        private static int IncreaseMinComp(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
        private static int DecreaseMinComp(int[] lhs, int[] rhs) => IncreaseMinComp(rhs, lhs);
    }
}
