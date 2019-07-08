using System;
//4. Перегрузка методів, Написати два методи з одинаковою назвою Add. Перший додає два числа, другий дві стрічки

namespace Сhapter4.Task4
{
    class Program
    {
        static int Add(int a, int b)
        {
            int sum = a + b;

            return sum;
        }
        static string Add(string firstStr, string secondStr)
        {
            string sum = firstStr + secondStr;

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string firstInt = Console.ReadLine();
            int i = int.Parse(firstInt);

            Console.WriteLine("Enter second number");
            string secondInt = Console.ReadLine();
            int n = int.Parse(secondInt);

            Console.WriteLine(Add(i, n));

            Console.WriteLine("Enrter first string");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();

            Console.WriteLine(Add(firstString, secondString));

            Console.ReadLine();
        }
        
    }
}
