using System;

//10. Написати метод, який приймає приймає налебл число(int?). Метод вертає 0 якщо прийов null, в іншому випадку саме число. Перевірку зробити двома способами(if HasValue i ??)
namespace Chapter4.Task10
{
    class Program
    {

        static void FirstMethod(int?[] array)
        {
            foreach (int? num in array)
            {
                if (num.HasValue)
                {
                    Console.WriteLine($"Method return number = {num.Value}");
                }
                else
                {
                    Console.WriteLine($"ethod return {0} ");
                }
            }
        }
        static void SecondMethod(int?[] array)
        {
            foreach(int? num in array)
            {
                int? m = num;
                int obj = m ?? 0;
                Console.WriteLine($"Method return {obj} ");
            }
        }
        static void Main(string[] args)
        {
            int? a = 2;
            int? b = null;
            int? c = 1;

            int?[] array = { a, b, c };

            FirstMethod(array);
            SecondMethod(array);


            Console.ReadLine();
        }
    }
}
