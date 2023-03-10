using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem7
{
    internal class TwoMas
    {


        public static int[,] CreateArray()
        {
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[colums, row];
            mass = TwoMas.FillArray(mass);
            TwoMas.PrintMass(mass);
            return mass;
        }
        public static double[,] CreateArrayDouble()
        {
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            double[,] mass = new double[colums, row];
            mass = TwoMas.FillArrayDouble(mass,1,10);
            TwoMas.PrintMassDouble(mass);
            return mass;
        }
        public static void PrintMass(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMassString(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMassDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]:f2} ");
                }
                Console.WriteLine();
            }
        }
        // Заполнить двумерный массив рандомом
        public static int[,] FillArray(int[,] array, int minRan = 1, int maxRan =10)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(minRan, maxRan);
                }
                Console.WriteLine();
            }
            return array;
        }
        public static double[,] FillArrayDouble(double[,] array, int minValue, int maxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
                }
                Console.WriteLine();
            }
            return array;
        }
    }
}

