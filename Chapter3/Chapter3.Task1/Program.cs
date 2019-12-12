using System;
//1. Зчитати з екрану стрічку і вивести на екран її довжину

namespace Chapter3.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your word");
            string firstStr = Console.ReadLine();

            Console.WriteLine("Word has {0} characters", firstStr.Length);

            Console.ReadLine();
        }
    }
}
