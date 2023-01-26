//Задача 51: Задайте двумерный массив.
//Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
using System;

namespace Sem7
{
    internal class HM51
    {
        internal static void Start()
        {
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[colums, row];
            mass = TwoMas.FillArray(mass);
            TwoMas.PrintMass(mass);
            Search(mass);

            void Search(int[,] array)
            {
                int result = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i==j)
                        {
                            result += array[i, j];
                        }
                    }
                }
                Console.WriteLine($"Сумма равна = {result}");
            }
        }
    }
}