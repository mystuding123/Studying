using System;

namespace Сhapter4.Task4
{
    class Program
    {
        static int Add(int a, int b)
        {
            Console.WriteLine("Enter first number");
            string firstInt = Console.ReadLine();
            int i = int.Parse(firstInt);

            Console.WriteLine("Enter second number");
            string secondInt = Console.ReadLine();
            int n = int.Parse(secondInt);

            int sum = i + n;

            return sum;
        }
        static string Add(string firstStr, string secondStr)
        {
            Console.WriteLine("Enrter first string");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();

            string sum = firstString + secondString;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2));
            Console.ReadLine();

            Console.WriteLine(Add(firstStr:" ", secondStr:" " ));
            Console.ReadLine();
        }
        
    }
}
