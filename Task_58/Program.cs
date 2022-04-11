using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_58
{
    internal class Program
    {
        //Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.

        static void Main(string[] args)
        {
            // делала ее ранее в допах
            int sizearrayone = 6;
            int sizearraytwo = 6;
            int[,] firstArray = new int[sizearrayone, sizearraytwo]; 
            int[,] secondArray = new int[sizearraytwo, sizearrayone];
            int[,] multyArray = new int[sizearrayone, sizearrayone];


            CreateArray(firstArray);
            Console.WriteLine("первая матрица");
            PrintArray(firstArray);

            CreateArray(secondArray);
            Console.WriteLine("вторая матрица");
            PrintArray(secondArray);

            MultyArray(firstArray, secondArray);


            Console.WriteLine("произведение матриц");
            PrintArray(multyArray);

            Console.ReadLine();

            void CreateArray(int[,] array)
            {
                Random rnd = new Random();
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                    for (int j = 0; j < colone; j++)
                        array[i, j] = rnd.Next(-9, 10);
            }

            void PrintArray(int[,] array)
            {
                int road = array.GetLength(0);
                int colone = array.GetLength(1);
                for (int i = 0; i < road; i++)
                {
                    for (int j = 0; j < colone; j++)
                        Console.Write($"{array[i, j]} | ");
                    Console.WriteLine();
                }
            }

            void MultyArray(int[,] arrayone, int[,] arraytwo) // заполнение матрицы произведений
            {
                for (int i = 0; i < sizearrayone; i++)
                    for (int j = 0; j < sizearrayone; j++)
                        CalcCells(i, j);


                void CalcCells(int multi, int multj) // расчет произведения  отдельной ячейки
                {
                    int temp = arrayone.GetLength(1);
                    for (int i = 0; i < temp; i++)
                        multyArray[multi, multj] += arrayone[multi, i] * arraytwo[i, multj];
                }


            }


        }
    }
}
