using System;

namespace Сhapter4Task3
{
    class Program
    {
        static int AddInt(params int[] numbers)
        {
            Console.WriteLine("Write {0} ints.", numbers.Length);

            int sum = 0;
            for (int a = 0; a < numbers.Length; a++)
                sum += numbers[a];

            return sum;

        }
        static void Main(string[] args)
        {
            int sum;
            sum = AddInt(3, 5, 7, 10);
            Console.WriteLine("Summa ints: {0} ", sum);

            Console.ReadLine();
        }
    }
}
