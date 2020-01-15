using System;
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
        static void WriteMatrix(int[,] matrix, int numRows, int numColums)
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColums; j++)
                {
                    Console.Write("{0 } ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void WriteArray(int [] sumRowsArray, int [] sumColumnArray, int numRows, int numColumn)
        {
            for(int i = 0; i < numRows; i++ )
            {
                Console.Write("Sum rows = {0 } ", sumRowsArray[i]);
                Console.WriteLine();
            }
            for (int i = 0; i < numColumn; i++)
            {
                Console.Write("Sum Array colums = {0 }", sumColumnArray[i]);
                Console.WriteLine();
            }
        }
        static void SumRowsArray(int[] sumRowsArray, int[] sumColumsArray, int[,] matrix, int numRows, int numColumn)
        {
            for (int i = 0; i < numColumn; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    sumRowsArray[i] += matrix[j, i];
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    sumColumsArray[i] += matrix[i, j];
                }
            }
        }
        static void firstArray()
        {
            int numRows = ReadInt("Enter Lenght");
            int numColumn = ReadInt("Enter column");

            int [,] myMatrix = new int[numRows, numColumn];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    Console.WriteLine("Enter [{0},{1}] num", i + 1, j + 1);
                    myMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            WriteMatrix(myMatrix, numRows, numColumn);

            int[] sumColumsArray = new int[numColumn];
            int[] sumLenghtArray = new int[numRows];

            SumRowsArray(sumColumsArray, sumLenghtArray, myMatrix, numRows, numColumn);
            WriteArray(sumLenghtArray, sumColumsArray, numRows, numColumn);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            firstArray();
            Console.ReadKey();
        }
    }
}