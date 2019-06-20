using System;

namespace Сhapter4.Task2
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int num = a;
            a = b;
            b = num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write first number");
            string firstStr = Console.ReadLine();
            int a = int.Parse(firstStr);

            Console.WriteLine("Write second number");
            string secondStr = Console.ReadLine();
            int b = int.Parse(secondStr);

            Console.WriteLine("Before: {0}, {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After: {0}, {1}", a, b);
            Console.ReadLine();
        }
    }
}
