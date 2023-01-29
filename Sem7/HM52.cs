//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using System;

namespace Sem7
{
    internal class HM52
    {
        internal static void Start()
        {
            
            double[,] masiv = CreateArray();
            //masiv = ParseInDouble(masiv);
            Arifmet(masiv);


            void Arifmet(double[,] array)
            {
                double temp = 0;
                
                for (int i = 0; i < array.GetLength(1); i++)//столбец
                {
                    temp = 0;
                    double[] result = new double[array.GetLength(0)];//каждый заход в столб обнуляем
                    for (int j = 0; j < array.GetLength(0); j++)//строкец
                    {
                        result[i]+= array[j,i];
                        
                    }
                    for (int k = 0; k < result.Length; k++)
                    {
                        temp += result[k];

                    }
                    temp = temp / array.GetLength(0);
                    Console.WriteLine($"Среднее арифмет столбца {i + 1} - > {temp:f2}");
                }
                
            }
        }

        //static double[,] ParseInDouble(int[,] masiv)
        //{
        //    double[,] doubleType = new double[masiv.GetLength(0), masiv.GetLength(1)];
        //    double[] forParse = new double[masiv.GetLength(0)];

        //    for (int i = 0; i < masiv.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < masiv.GetLength(1); j++)
        //        {
        //            forParse[j] = (int)masiv[i,j];

        //        }
                
        //    }
        //    return doubleType;
        //}
        public static double[,] CreateArray()
        {
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            double[,] mass = new double[colums, row];
            mass = FillArrayDouble(mass);
            PrintMassDouble(mass);
            return mass;
        }
        public static double[,] FillArrayDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1,10);
                }
                Console.WriteLine();
            }
            return array;
        }
        public static void PrintMassDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]:f0} ");
                }
                Console.WriteLine();
            }
        }
    }
}