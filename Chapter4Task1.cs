using System;
//1. Зчитати стрічку з консолі. Використовуючи метод int.TryParse вивести стрічка не є числом, якщо метод повернув false,  в іншому випадку вивести число в степені 5.
namespace Chapter4Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;     
            Console.WriteLine("Select number");
            String myStr = Console.ReadLine();;
            bool result = double.TryParse(myStr, out num);
            if (result == true)       
                Console.WriteLine(Math.Pow(num,5));
            else
                Console.WriteLine("false");
            Console.ReadLine();       
        }
    }
}
