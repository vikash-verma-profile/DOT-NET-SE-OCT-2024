using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class3
    {
        public static void Main3()
        {
            //write a program to get sum of 10 number
            //int length =7;
            //int[] numbers = new int[length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]+ " ");
            //}

            //int s = Console.Read();
            //string sample=Console.ReadLine();

            //Console.WriteLine(s);
            //Console.WriteLine(sample);
            //write a program to sum two matrix
            int[,] matrix = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine($"Please enter a value for [{row},{col}]");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
