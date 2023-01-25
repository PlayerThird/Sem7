//Задайте двумерный массив.
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
//выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть 
//вот так:
//1 4 7 2
//5 81 2 9
//8 4 2 4

using System;

namespace Sem7
{
    internal class HM49
    {
        internal static void Start()
        {
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[colums, row];
            mass = TwoMas.FillArray(mass);
            mass = Qatro(mass,colums,row);
            TwoMas.FillArray(mass);

            int[,] Qatro(int[,] array,int x, int y)
            {
                for (int i = 0; i < x; i+=2)
                {
                    for (int j = 0; j < y; j+=2)
                    {
                        array[i, j] *= array[i, j];
                    }
                }
                
                return array;
            }
        }
    }
}