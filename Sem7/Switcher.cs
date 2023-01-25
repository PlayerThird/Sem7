using System;

namespace Sem7
{
    internal class Switcher
    {
        internal static void Start()
        {
            int y = Checker.CheckInput<int>(x => x < 46 || x > 52, "Введите номер программы: ", "Такой программы нет");
            bool check = false;
            switch (y)
            {
                case 46:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM46.Start();
                    break;
                case 47:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM47.Start();
                    break;
                case 48:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM48.Start();
                    break;
                case 49:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM49.Start();
                    break;
                case 50:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM50.Start();
                    break;
                case 51:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM51.Start();
                    break;
                case 52:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM52.Start();
                    break;

                default:
                    Console.WriteLine("Такой программы нет");
                    Console.ReadLine();
                    CheckContinue(check);
                    break;
            }

            bool UnlockTasks()
            {
                bool check = false;
                Console.WriteLine("Это та программа, которая вам нужна?( + или - )");
                string answer = Console.ReadLine();
                string v = "+";
                if (answer == v)
                {
                    check = true;
                }
                return check;
            }
            void DiscriptionTasks(int y)
            {
                switch (y)
                {
                    case 46:
                        Console.WriteLine("// Задайте двумерный массив размером m×n," +
             "\r\nзаполненный случайными целыми числами");
                        break;
                    case 47:
                        Console.WriteLine("//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами." +
                            "\r\n//m = 3, n = 4." +
                            "\r\n//0,5 7 - 2 - 0,2" +
                            "\r\n//1 - 3,3 8 - 9,9" +
                            "\r\n//8 7,8 - 7,1 9");
                        break;
                    case 48:
                        Console.WriteLine("//Задайте двумерный массив размера m на n," +
                            "\r\n//каждый элемент в массиве находится по формуле: Aₘₙ = m+n." +
                            "\r\n//Выведите полученный массив на экран." +
                            "\r\n//m = 3, n = 4." +
                            "\r\n//0 1 2 3" +
                            "\r\n//1 2 3 4" +
                            "\r\n//2 3 4 5");
                        break;
                    case 49:
                        Console.WriteLine("//Задайте двумерный массив." +
                            "\r\n//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты." +
                            "\r\n//Например, изначально массив" +
                            "\r\n//выглядел вот так:" +
                            "\r\n//1 4 7 2" +
                            "\r\n//5 9 2 3" +
                            "\r\n//8 4 2 4" +
                            "\r\n//Новый массив будет выглядеть " +
                            "\r\n//вот так:" +
                            "\r\n//1 4 7 2" +
                            "\r\n//5 81 2 9" +
                            "\r\n//8 4 2 4");
                        break;
                    case 50:
                        Console.WriteLine("//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," +
                            "\r\n//и возвращает значение этого элемента или же указание, что такого элемента нет." +
                            "\r\n//Например, задан массив:" +
                            "\r\n//1 4 7 2" +
                            "\r\n//5 9 2 3" +
                            "\r\n//8 4 2 4" +
                            "\r\n\r\n//17->такого числа в массиве нет");
                        break;
                    case 51:
                        Console.WriteLine("//Задача 51: Задайте двумерный массив." +
                            "\r\n//Найдите сумму элементов," +
                            "\r\n//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д");
                        break;
                    case 52:
                        Console.WriteLine("//Задайте двумерный массив из целых чисел." +
                            "\r\n//Найдите среднее арифметическое элементов в каждом столбце." +
                            "\r\n//Например, задан массив:" +
                            "\r\n//1 4 7 2" +
                            "\r\n//5 9 2 3" +
                            "\r\n//8 4 2 4" +
                            "\r\n//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");
                        break;
                }
            }

            void CheckContinue(bool check)
            {
                if (check == false)
                {
                    Start();
                }
            }


        }
    }
}
