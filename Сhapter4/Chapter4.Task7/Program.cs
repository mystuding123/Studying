using System;
//Cтврити массив з n чисел(n зчитати з консолі массив також, вивести на екран посотований массив.
namespace Chapter4.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array length");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} num", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Array.Sort(array);
                Console.WriteLine("{0}", array[i]);
            }

            Console.ReadKey();
        }
    }
}
