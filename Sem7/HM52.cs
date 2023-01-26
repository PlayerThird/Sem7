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
            
            int[,] masiv = TwoMas.CreateArray();
            Arifmet(masiv);


            void Arifmet(int[,] array)
            {
                int[] result = new int[array.GetLength(0)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        result[i]+= array[i,j];
                        
                    }
                    Console.WriteLine($"Sum {i + 1} - > {result[i]}");
                }
                
            }
        }
    }
}