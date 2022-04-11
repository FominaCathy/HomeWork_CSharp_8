using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_54
{
    //Задача 54: Задайте двумерный массив. Напишите программу,
    //которая упорядочит по убыванию элементы каждой строки двумерного массива.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];

            FillArray();
            Console.WriteLine("исходная матрица:");
            PrintArray(); //печатаем изначальную матрицу

            for (int i = 0; i < array.GetLength(0); i++)
            {
                SortRow(i);

            }
            Console.WriteLine("новая матрица:");
            PrintArray();
            Console.ReadLine();

            void FillArray() // создаем случайную матрицу
            {
                Random rnd = new Random();
                for (int i = 0; i < array.GetLength(0); i++)
                    for (int j = 0; j < array.GetLength(1); j++)
                        array[i, j] = rnd.Next(0, 10);
            }

            void PrintArray() // печатаем матрицу, 
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                        Console.Write($" {array[i, j]} |");
                    Console.WriteLine();
                }
            }


            void SortRow (int numrow) //сортируем элементы в строке
            {
                int temp = 0;

                for (int i = 0; i < array.GetLength(1) - 1; i++)
                {
                    for (int j = 0; j < array.GetLength(1)-1-i; j++)
                    {
                        if (array[numrow, j] < array[numrow, j+1])
                        {
                            temp = array[numrow, j + 1];
                            array[numrow, j + 1] = array[numrow, j];
                            array[numrow, j] = temp;

                        }
                    }
                }
            }
        }
    }
}
