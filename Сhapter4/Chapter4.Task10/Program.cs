using System;

//10. Написати метод, який приймає приймає налебл число(int?). Метод вертає 0 якщо прийов null, в іншому випадку саме число. Перевірку зробити двома способами(if HasValue i ??)
namespace Chapter4.Task10
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");

            int? a = 2;
            int? b = null;
            int? c = 1;

            int?[] array = { a, b, c };
            foreach (int? num in array)
            {
                if (num.HasValue)
                {
                    Console.WriteLine($"If method return number = {num.Value}");
                }
                else
                {
                    Console.WriteLine($"If method return null = {0}");
                }
            }


        }
    }
}
