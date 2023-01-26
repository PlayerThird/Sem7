//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17->такого числа в массиве нет

using System;

namespace Sem7
{
    internal class HM50
    {
        internal static void Start()
        {
            int minRand = 0;
            int maxRand = 10;
            Console.WriteLine("Введите кол-во строк");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[colums, row];
            Console.WriteLine("Вы будете вводить отрезок рандома?(+ или энтер)");
            string checkRan = Console.ReadLine();
            if (checkRan == "+")
            {
                Console.WriteLine("Введите минимальный отрезок");
                minRand = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите маскимальный отрезок");
                maxRand = Convert.ToInt32(Console.ReadLine());
                if (minRand > maxRand)
                {
                    Console.WriteLine("Всё за вас делать --_--");
                    int temp = minRand;
                    minRand = maxRand;
                    maxRand = temp;
                }
            }



            mass = TwoMas.FillArray(mass, minRand, maxRand);
            TwoMas.PrintMass(mass);
            
            Switcher(mass);
            void Switcher(int[,] mass)
            {
                Console.WriteLine("Введите способ как вы будете искать число?" +
                "\r\n 1) Поиск числа" +
                "\r\n 2) Поиск по координатам числа" +
                "\r\n 3) Поиск по позиции");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        int search = Checker.CheckInput<int>(x => x < minRand || x > maxRand, "Введите число, которое хотите найти", "Ой, такого числа нет, сила рандома не достала его");
                        SearchNum(mass, search);
                        break;
                    case 2:
                        int columSer = Checker.CheckInput<int>(x => x > colums || x< 0, "Введите строку", "Эйэйэй, ты вышел за пределы строк!");
                        int rowSer = Checker.CheckInput<int>(x => x > row || x <0, "Введите столбец", "Эйэйэй, ты вышел за пределы столбиков!");
                        SearchCoordinate(mass, columSer, rowSer);
                        break;
                    
                    case 3:
                        int pozit = Checker.CheckInput<int>(x => x <= (minRand * maxRand), "Введите позицию, которую хотите найти", "А такой позиции нет!");
                        SearchPozition(mass, pozit);
                        break;
                    default:
                        Console.WriteLine("Ну почти, а теперь по новой");
                        Switcher(mass);
                        break;
                }
            }
            //Поиск по номеру
            void SearchNum(int[,] mas, int num)
            {
                for (int i = 0; i < mas.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mas.GetUpperBound(1); j++)
                    {
                        if (mas[i, j] == num)
                        {
                            Console.WriteLine($"О, такое число есть!{num} its here -> [{i},{j}]");
                            return;
                        }
                    }
                }
                Console.WriteLine($"Мы искали, мы искали, наши рученьки устали, но так и не нашли где {num}");
            }
            //Поиск по координатам
            void SearchCoordinate(int[,] mas, int colums, int row)
            {
                for (int i = 0; i < mas.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mas.GetUpperBound(1); j++)
                    {
                        if (i == colums-1 && j == row-1)
                        {
                            Console.WriteLine($"Мы нашли его! -> {mas[i,j]}");
                            return;
                        }
                    }
                }
                Console.WriteLine($"Мы искали, мы искали, наши рученьки устали, но так и не нашли где ваши координаты. Так, стоп, ты не должен был этого видеть!");
            }
            void SearchPozition(int[,] mas, int poz)
            {
                int k = 0;
                for (int i = 0; i < mas.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mas.GetUpperBound(1); j++)
                    {
                        if (poz-1 == k)
                        {
                            Console.WriteLine($"Мы нашли его! -> {mas[i, j]} на этой позиции ->{poz}");
                            return;
                        }
                        k++;
                    }
                }
            }

        }
    }
}