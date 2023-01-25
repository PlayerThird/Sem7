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
            Console.WriteLine();
            TwoMas.PrintMass(mass);
            Console.WriteLine("Вибирите способ решения задачи:" +
                "\r\n 1) Менять когда i и j % 2" +
                "\r\n 2) Менять если один из i или j % 2");
            int x = Checker.CheckInput<int>(x => x < 0 || x > 2,"1й вариант или 2й?","Ну что не видно, что такого варианта нет!?");
            if (x ==1 )
            {
                mass = Qatro(mass, colums, row);
                Console.WriteLine();
                TwoMas.PrintMass(mass);
                string[,] stroki = CopyString(mass, colums, row);
                Console.WriteLine();
                TwoMas.PrintMassString(stroki);
            }
            else
            {
                mass = Duos(mass, colums, row);
                Console.WriteLine();
                TwoMas.PrintMass(mass);
                string[,] stroki = CopyStrDuos(mass, colums, row);
                Console.WriteLine();
                TwoMas.PrintMassString(stroki);
            }
            

            int[,] Qatro(int[,] array, int x, int y)
            {
                for (int i = 0; i < x; i += 2)
                {
                    for (int j = 0; j < y; j += 2)
                    {
                        array[i, j] *= array[i, j];
                    }
                }

                return array;
            }

            string[,] CopyString(int[,] mas, int colums, int row)
            {
                string[,] stringers = new string[colums, row];
                string stars = "*";
                for (int i = 0; i < colums; i++)
                {

                    for (int j = 0; j < row; j++)
                    {
                        stringers[i, j] = Convert.ToString(mas[i, j]);
                        if (i % 2 == 1 || j % 2 == 1)
                        {
                            stringers[i, j] = stars;
                        }
                        
                    }
                }
                return stringers;
            }
            int[,] Duos(int[,] array, int x, int y)
            {
                for (int i = 0; i < x; i += 1)
                {
                    for (int j = 0; j < y; j += 1)
                    {
                        if (i % 2 == 0 || j % 2 ==0)
                        {
                            array[i, j] *= array[i, j];
                        }
                        
                    }
                }

                return array;
            }

            string[,] CopyStrDuos(int[,] mas, int colums, int row)
            {
                string[,] stringers = new string[colums, row];
                string stars = "*";
                for (int i = 0; i < colums; i++)
                {

                    for (int j = 0; j < row; j++)
                    {
                        stringers[i, j] = Convert.ToString(mas[i, j]);
                        if (i % 2 == 1 && j % 2 == 1)
                        {
                            stringers[i, j] = stars;
                        }

                    }
                }
                return stringers;
            }
        }
    }
}