using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void WriteMatrix(int[,] matrix, int numRows , int numColums)
        {
            for(int i = 0; i < numRows; i++)
            {
                for(int j = 0; j < numColums; j++)
                {
                    Console.Write("{0} ",matrix[i, j]);
                }
                Console.WriteLine();

            }

        }
        static void MultiplyMatrices(int[,] firstMatrix,int firstRows, int firstColums, int [,] secondMatrix, int secondRows, int secondColums)
        {
            if (firstColums != secondRows)
            {
                Console.WriteLine("Validation error.invalid matrices size");
                return;
            }
            WriteMatrix(firstMatrix, firstRows, firstColums);
            WriteMatrix(secondMatrix, secondRows, secondColums);

            int[,] result = new int[firstRows, secondColums];
            for(int i = 0; i < firstRows; i++)
            {
                for(int j = 0; j < secondColums; j++)
                {
                    for (int h = 0; h < firstColums; h++)
                    {
                        result[i, j] = firstMatrix[i, h] * secondMatrix[h, j];
                    }
                }
            }
            WriteMatrix(result, firstRows, secondColums);
        }
        static void Main(string[] args)
        {
            int numRowsOne = 5;
            int numColumsOne = 1;
            int[,] matNumOne = new int[numRowsOne, numColumsOne];
            matNumOne[0, 0] = 5;
            matNumOne[1, 0] = 2;
            matNumOne[2, 0] = 4;
            matNumOne[3, 0] = 7;
            matNumOne[4, 0] = 0;

            int numRowsTwo = 1;
            int numColumsTwo = 3;
            int[,] matNumTwo = new int[1, 3];
            matNumTwo[0, 0] = 3;
            matNumTwo[0, 1] = 1;
            matNumTwo[0, 2] = 9;

            MultiplyMatrices(matNumOne, numRowsOne, numColumsOne, matNumTwo, numRowsTwo, numColumsTwo);

            int numRowsThree = 2;
            int numColumsThree = 3;
            int[,] matNumTree =
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            int numRowsFour = 3;
            int numColumnFour = 4;
            int[,] matNumFour =
            {
                {3, 2, 4, 8 },
                {3, 7, 6, 2 },
                {1, 6, 8, 2 }
            };

            MultiplyMatrices(matNumTree, numRowsThree, numColumsThree, matNumFour, numRowsFour, numColumnFour);

            int numRowsFive = 3;
            int numColumnFive = 3;
            int[,] matNumFive =
            {
                {2, 1, 4 },
                {3, 2, 5 },
                {4, 3, 6 }
            };

            int numRowsSix = 3;
            int numColumnSix = 3;
            int[,] matNumSix =
            {
                {9, 8, 7 },
                {6, 5, 4 },
                {3, 2, 1 }
            };

            MultiplyMatrices(matNumFive, numRowsFive, numColumnFive, matNumSix, numRowsSix, numColumnSix);

            int numRowsSeven = 1;
            int numColumnSeven = 5;
            int[,] matNumSeven =
            {
                {7, 6, 7, 5, 3 }
            };

            int numRowsEight = 5;
            int numColumnEight = 1;
            int[,] matNumEight =
            {
                {4 },
                {3 },
                {2 },
                {1 },
                {5 }
            };

            MultiplyMatrices(matNumSeven, numRowsSeven, numColumnSeven, matNumEight, numRowsEight, numColumnEight);

            Console.ReadKey();
        }
    }
}

