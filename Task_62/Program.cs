using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_62
{
    internal class Program
    {
        //Задача 62: Заполните спирально массив 4 на 4 числамиот 1 до 16.
        static void Main(string[] args)
        {

            int[,] array = new int[4, 4];

            FillArraySpiral();
           
            PrintArray(); //печатаем матрицу

            
            
            Console.ReadLine();

            void FillArraySpiral() // создаем матрицу
            {
                int count = 1; // начальное значение в матрицы
                int i; 
                int temp = 0;
                int colone = array.GetLength(1);
                int row = array.GetLength(0);

                while (temp < colone)
                {
                    for (i = temp; i < colone; i++) // проход вправо
                    {
                        array[temp, i] = count;
                        count++;
                    }

                    for (i = 1+temp; i < row; i++) // проход вниз
                    {
                        array[i, colone - 1] = count;
                        count++;
                    }

                    for (i = colone - 2; i >= 0+temp; i--) // проход влево
                    {
                        array[row - 1, i] = count;
                        count++;
                    }

                    for (i = row - 2; i > 0+temp; i--) // проход вверх
                    {
                        array[i, temp] = count;
                        count++;
                    }

                    temp++;
                    colone--;
                    row--;


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
