//Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
using System;

namespace Sem7
{
    internal class HM48
    {
        internal static void Start()
        {
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[colums, row];
            FillArray(mass);
            TwoMas.PrintMass(mass);

            void FillArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = i + j;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}