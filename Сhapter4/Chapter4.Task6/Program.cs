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
        static void SumRowsArray(int[] firstArray, int[] secondArray, int[,] matrix, int numRows, int numColumn)
        {
            for (int i = 0; i < numColumn; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    firstArray[i] += matrix[j, i];
                }
                Console.Write("Sum rows = {0 } ", firstArray[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    secondArray[i] += matrix[i, j];
                }
                Console.Write("Sum Array colums = {0 }", secondArray[i]);
            }
            Console.WriteLine();
        }
        static void firstArray()
        {
            int numColumn = ReadInt("Enter Column");
            int numLenght = ReadInt("Enter Lenght");
            int[,] myMatrix;
            myMatrix = new int[numLenght, numColumn];

            for (int i = 0; i < numLenght; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    Console.WriteLine("Enter [{0},{1}] num", i + 1, j + 1);
                    myMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            WriteMatrix(myMatrix, numLenght, numColumn);

            int[] sumColumsArray = new int[numColumn];
            int[] sumLenghtArray = new int[numLenght];

            SumRowsArray(sumColumsArray, sumLenghtArray, myMatrix, numLenght, numColumn);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            firstArray();
            Console.ReadKey();
        }
    }
}