using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class4
    {
        public static void Main4()
        {
            int[][] jagged_array1 = new int[5][];
            int[][] jagged_array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{11,12,13},
                new int[] {14,15},
                new int[] {0,45,78,89,90}
            };
            for (int n = 0; n < jagged_array.Length; n++)
            {
                for (int i = 0; i < jagged_array[n].Length; i++)
                {
                    Console.Write(jagged_array[n][i]+",");
                }
                Console.WriteLine();
            }
        }
    }
}
