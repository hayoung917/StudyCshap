﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCallback
{
    delegate int Compare(int a, int b);
    class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;

            else if (a == b)
                return 0;

            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;

            else if (a == b)
                return 0;

            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int temp = 0;

            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int j = 0; j < DataSet.Length - (i+1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                } 
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, new Compare(AscendCompare));

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorting decending...");
            BubbleSort(array, new Compare(DescendCompare));

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
