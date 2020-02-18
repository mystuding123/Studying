using System;
//1. 	- В класі Program оголосити:
//константу типу int
//приватне статичне readonly поле типу int, якому в статичному констркукторі присвоюється якесь значення(зчитується з консолі)
//    в методі мейн виводиться на екран добуток сума і різниця константи і статичного поля
namespace Chapter5.Task1
{
    class Program
    {
        const int a = 10;
        private static readonly int num;
        static Program()
        {
            Console.WriteLine("Enter your number");
            string str = Console.ReadLine();
            num = int.Parse(str);
        }
        static void Operation()
        {
           int sum = a + num;
           int dif = a - num;
           int mult = a * num;
            Console.WriteLine($"Sum = {sum}, dif = {dif}, mult = {mult} ");
        }
        static void Main(string[] args)
        {
            Operation(); 
        }
    }
}
