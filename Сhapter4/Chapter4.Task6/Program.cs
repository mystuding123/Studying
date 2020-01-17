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
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        static void SumArrays(out int[] sumRowsArrays, out int[] sumColumsArray, int numColumn, int numRows, int[,] matrix)
        {
            sumRowsArrays = new int[numColumn];
            sumColumsArray = new int[numRows];
            for (int i = 0; i < numColumn; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    sumRowsArrays[i] += matrix[j, i];
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

        static void TaskWithMatrix()
        {
            int numRows = ReadInt("Enter Lenght");
            int numColumn = ReadInt("Enter column");

            int[,] myMatrix = new int[numRows, numColumn];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    myMatrix[i, j] = ReadInt(string.Format($"Enter[{i + 1}, {j + 1}] num"));
                }
            }

            WriteMatrix(myMatrix, numRows, numColumn);

            SumArrays(out int [] sumRowsArray, out int [] sumColumsArray, numColumn, numRows, myMatrix);

            Console.WriteLine("Rows sum");
            WriteArray(sumRowsArray);

            Console.WriteLine("Column sum");
            WriteArray(sumColumsArray);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            TaskWithMatrix();
            Console.ReadKey();
        }
    }
}