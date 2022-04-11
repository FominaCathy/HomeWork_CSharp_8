using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_60
{
    internal class Program
    {
        // Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
        // Напишите программу, которая построчно выведет элементы и их индексы.
        static void Main(string[] args)
        {
            int[,,] array = new int[5, 4, 4];

            int count = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);
            //макс кол-во элементов в матрице = 90 шт
            if (count > 89)
                Console.WriteLine("матрица слишком велика и не может быть заполнена. уменьшите размер матрицы");
            else
            {
                Console.WriteLine("матрица");
                FillArray();
                PrintArray();
            }
            Console.ReadLine();

            void FillArray()
            {
                Random rnd = new Random();

                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                int arr = array.GetLength(2);
                int temp;

                List<int> numsList = new List<int>();

                // создаем и заплняем лист со значениями
                for (int i = 10; i < 100; i++)
                    numsList.Add(i);

                for (int i = 0; i < road; i++)
                    for (int j = 0; j < colone; j++)
                        for (int k = 0; k < arr; k++)
                        {
                            temp = rnd.Next(0, numsList.Count()); // берем случайный элемент из списка
                            array[i, j, k] = numsList[temp];
                            numsList.RemoveAt(temp); // удаляем этот илемент из списка
                        }

            }

            void PrintArray()
            {
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                int arr = array.GetLength(2);

                for (int i = 0; i < road; i++)
                {
                    Console.WriteLine($"строка {i}:");

                    for (int j = 0; j < colone; j++)
                    {
                        for (int k = 0; k < arr; k++)
                            Console.Write($"{array[i, j, k]} :[{i},{j},{k}] | ");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
