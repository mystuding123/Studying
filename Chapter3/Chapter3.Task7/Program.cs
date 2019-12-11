using System;
7. Зчитати стрічку з екрану, якщо ввели B - вивести BMW, якщо M - Mersedess, W - Wolzvagen інакше вивести unknown car(використовуй switch -case)
namespace SchoolBox.task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string myString;

            Console.WriteLine("Enter the pass");
            myString = Console.ReadLine();

            if (myString.Length < 5)
            {
                Console.WriteLine("5");
            }
            else if ((myString.Length >= 5) && (myString.Length <= 10))
            {
                Console.WriteLine("10");
            }
            else if (myString.Length > 10)
            {
                Console.WriteLine(11);
            }

            Console.ReadLine();
        }
    }
}
