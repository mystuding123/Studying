using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//6. створити двовимірний масив, розміром n на m(n - кіслькість рядків, m - кількість стовпців). n та m не обовязково зчитувати з консолі.Заповнити довільними значеннями матрицю.Створити два одновимірні масиви. Перший, розміром n, кожен елемент якого - це сума чисел чисел у рядку. другий, розміром m, кожен елемент якого - це сума чисел чисел у стовпці

namespace Chapter4.Task6
{
    class Program
    {
        static int ReadInt(string text)
        {
            Console.WriteLine(text);
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);

            return num;
        }
        static void firstArray()
        {
            int numColumn = ReadInt("Enter hight");
            int numLenght = ReadInt("Enter lenght");

            int[,] myMatrix;
            myMatrix = new int[numColumn, numLenght];

            for (int i = 0; i < numColumn; i++)

                for (int j = 0; j < numLenght; j++)
                {
                    Console.WriteLine("Enter {0} num", i + 1);
                    myMatrix[i,j] = int.Parse(Console.ReadLine());

                }
            int sum1;
            sum1 = 0;
            int sum2;
            sum2 = 0;

            for (int i = 0; i < numColumn; i++)
            {
                sum1 += sum1 + myMatrix[i, numColumn];
                Console.WriteLine(sum1);
            }
      
                for (int j = 0; j < numLenght; j++)
                {
                sum2 += sum2 + myMatrix[numLenght, j];
                Console.WriteLine(sum2);
                }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            firstArray();
            Console.ReadKey();
        }
    }
}