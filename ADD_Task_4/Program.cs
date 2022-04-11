using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_4
{
    //Задача 4.Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];

             FillArraySnake();

             PrintArray(); //печатаем матрицу

             Console.ReadLine();

             void FillArraySnake() // создаем матрицу
             {
                int count = 1; // начальное значение в матрицы
                int i;
                int temp = 0;
                int colone = array.GetLength(1);
                int row = array.GetLength(0);

                while (temp < colone)
                {
                    for (i = 0; i < row; i++) // проход вниз
                    {
                        array[i, temp] = count;
                        count++;
                    }
                    temp++;

                    if (temp < colone)
                    {
                        for (i = row - 1; i >= 0; i--) // проход вверх
                        {
                            array[i, temp] = count;
                            count++;
                        }
                        temp++;
                    }
                }
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
        }
    }
}
