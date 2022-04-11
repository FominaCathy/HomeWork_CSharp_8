using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_1
{
    //Задача 1. 1. Дан двумерный массив.
    //Заменить в нём элементы первой строки элементами главной диагонали.
    //А элементы последней строки, элементами побочной диагонали.

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            int colone = array.GetLength(1);
            int row = array.GetLength(0);

            FillArray();
            Console.WriteLine("исходная матрица:");
            PrintArray(); //печатаем изначальную матрицу
            Replace();


            Console.WriteLine("новая матрица:");
            PrintArray();
            Console.ReadLine();

            void FillArray() // создаем случайную матрицу
            {
                //int count =1; //делала для теста
                Random rnd = new Random();
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < colone; j++)
                        array[i, j] = rnd.Next(0, 10); //count++; делала для теста


            }

            void PrintArray() // печатаем матрицу, 
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colone; j++)
                        Console.Write($" {array[i, j]} |");
                    Console.WriteLine();
                }
            }


            void Replace() //
            {
                int temp = 0;
                int i;

                for (i = 1; i < colone; i++)
                {// ?? в последней колонке. чтобы она заменялась на изначальное значение, а не уже измененное
                    if (i == colone - 1) 
                    {
                        temp = array[0, i];
                        array[0, i] = array[i, i]; //Заменяем элементы первой строки элементами главной диагонали
                        array[row - 1, i] = temp; //Заменяем элементы последней строки, элементами побочной диагонали
                    }
                    else
                    {
                        array[0, i] = array[i, i]; //Заменяем элементы первой строки элементами главной диагонали
                        array[row - 1, i] = array[row - 1 - i, i]; //Заменяем элементы последней строки, элементами побочной диагонали

                    }
                }
            }
        }
    }
}
