using System;

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
            int b = int.Parse(str);
            num = b;
        }
        private void Operation()
        {
           int sum = a + num;
           int dif = a - num;
           int mult = a * num;
            Console.WriteLine($"Sum = {sum}, dif = {dif}, mult = {mult} ");
        }
        static void Main(string[] args)
        {
            Program c = new Program();
            c.Operation();
        }
    }
}
