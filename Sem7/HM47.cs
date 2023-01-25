//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 - 2 - 0,2
//1 - 3,3 8 - 9,9
//8 7,8 - 7,1 9

using System;

namespace Sem7
{
    internal class HM47
    {
        internal static void Start()
        {
            //new Random().NextDouble()
            //new Random().NextDouble() * (maxValue - minValue) + minValue;
            Console.Clear();

            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());

            double[,] array = GetArray(rows, columns, -10, 10);
            TwoMas.PrintMassDouble(array);

            double[,] GetArray(int m, int n, double minValue, double maxValue)
            {
                double[,] result = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
                    }
                }
                return result;
            }
        }
    }
}