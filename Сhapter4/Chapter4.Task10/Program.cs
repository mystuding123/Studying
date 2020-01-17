using System;

//10. Написати метод, який приймає приймає налебл число(int?). Метод вертає 0 якщо прийов null, в іншому випадку саме число. Перевірку зробити двома способами(if HasValue i ??)
namespace Chapter4.Task10
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");

                Nullable<int> a = new Nullable<int>(1);
                Nullable<int> b = null;
                Nullable<int> c = new Nullable<int>(2);

                Nullable<int>[] array = { a, b, c };
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
