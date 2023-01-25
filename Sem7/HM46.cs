using System;

namespace Sem7
{
    internal class HM46
    {
        internal static void Start()
        {
            // Задайте двумерный массив размером m×n, 
            // заполненный случайными целыми числами

            Console.Clear();

            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array = GetArray(rows, columns, 0, 10);
            TwoMas.PrintMass(array);

            int[,] GetArray(int m, int n, int minValue, int maxValue)
            {
                int[,] result = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = new Random().Next(minValue, maxValue + 1);
                    }
                }
                return result;
            }
        }
    }
}