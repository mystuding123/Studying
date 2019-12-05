using System;
//2. Зчитати стрічку з екрану, створити метод який вертає стрічку без пробілів
namespace Chapter3.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string firstStr = Console.ReadLine();

            firstStr = firstStr.Replace(" ", "");
            Console.WriteLine(firstStr);

            Console.ReadLine();
        }
    }
}
