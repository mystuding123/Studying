using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matNumOne = new int[5, 1];
            matNumOne[0, 0] = 5;
            matNumOne[1, 0] = 2;
            matNumOne[2, 0] = 4;
            matNumOne[3, 0] = 7;
            matNumOne[4, 0] = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write(matNumOne[i, j]);
                }

                Console.WriteLine();
            }

            int[,] matNumTwo = new int[1, 3];
            matNumTwo[0, 0] = 3;
            matNumTwo[0, 1] = 1;
            matNumTwo[0, 2] = 9;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matNumTwo[i, j]);
                }

                Console.WriteLine();
            }

            int[,] matNumTree =
            {
                {1, 2, 3 },
                { 4, 5, 6}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matNumTree[i, j]);
                }
                Console.WriteLine();
            }

            int[,] matNumFour =
            {
                {3, 2, 4, 8 },
                {3, 7, 6, 2 },
                {1, 6, 8, 2 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matNumFour[i, j]);
                }
                Console.WriteLine();
            }

            int[,] matNumFive =
            {
                {2, 1, 4 },
                {3, 2, 5 },
                {4, 3, 6 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matNumFour[i, j]);
                }
                Console.WriteLine();

            }

            int[,] matNumSix =
            {
                {9, 8, 7 },
                {6, 5, 4 },
                {3, 2, 1 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matNumFive[i, j]);
                }
                Console.WriteLine();
            }

            int[,] matNumSeven =
            {
                {7, 6, 7, 5, 3 }
            };

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matNumSeven[i, j]);
                }
                Console.WriteLine();

            }

            int[,] matNumEight =
            {
                {4 },
                {3 },
                {2 },
                {1 },
                {5 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write(matNumEight[i, j]);
                }
                Console.WriteLine();
            }

            int[,] sumMat = new int[5, 3];
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 3; j++)
                {

                    {
                        sumMat[0, 0] = matNumFive[0, 0] * matNumSix[0, 0] + matNumFive[0, 1] * matNumSix[1, 0] + matNumFive[0, 2] * matNumSix[2, 0];
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", sumMat[0, 0]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

