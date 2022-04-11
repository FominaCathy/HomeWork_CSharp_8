using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_2
{
    internal class Program
    {
        //Задача 2. Дан двумерный массив, заполненный случайными числами от -9 до 9.
        //Подсчитать частоту вхождения каждого числа в массив, используя словарь.

        static void Main(string[] args)
        {

            int[,] array = new int[7, 7];
            int colone = array.GetLength(1);
            int row = array.GetLength(0);

            Dictionary<int, int> countValue = new Dictionary<int, int>();

            FillArray();
            Console.WriteLine("матрица:");
            PrintArray(); //печатаем матрицу

            FillDictionary();

            Console.WriteLine("частота вхождения:");
            foreach (var number in countValue)
            {
                Console.WriteLine($"значение {number.Key} -входит {number.Value} раз/раза");
            }

            Console.ReadLine();

            void FillArray() // создаем случайную матрицу
            {
                Random rnd = new Random();
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < colone; j++)
                        array[i, j] = rnd.Next(-9, 10); 
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

            void FillDictionary() 
            //заполняем словарь. можно было его заполнить при заполнении матрицы, но я вынесла в отдельный метод 
            {

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colone; j++)
                        if (countValue.ContainsKey(array[i, j]) == true)
                            countValue[array[i, j]]++;
                        else
                            countValue.Add(array[i, j], 1);
                }
            }
        }
    }
}
