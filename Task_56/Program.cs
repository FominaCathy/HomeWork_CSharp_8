using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 56: Задайте прямоугольный двумерный массив.
            //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            int[,] array = new int[5, 8];
            int minrow; 
            int summrow;
            int tempsumm;


            FillArray();
            Console.WriteLine("исходная матрица:");
            PrintArray(); //печатаем изначальную матрицу

            summrow = CalcSummRow(0);
            minrow = 0;
            Console.WriteLine($"сумма строки: 0 = {summrow} ");
            for (int i = 1; i < array.GetLength(0); i++)
            {
                tempsumm = CalcSummRow(i);
                Console.WriteLine($"сумма строки: {i} = {tempsumm} ");
                if (summrow > tempsumm)
                {
                    summrow = tempsumm;
                    minrow = i;
                }

            }
            Console.WriteLine($"миним сумма в строке {minrow}  и = {summrow}");

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


            int CalcSummRow(int numrow) //ищем сумму элементов в строке
            {
                int summ = 0;

                for (int i = 0; i < array.GetLength(1); i++)
                {
                    summ += array[numrow, i];
                }

                return summ;

            }
        }
       
    }
}
