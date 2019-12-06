using System;
//3. Зчитати два числа з екрану, вивести на екран їх суму, різницю, добуток. Використовувати string.Format() для виведення даних
namespace SchoolBox.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string firstStr = Console.ReadLine();
            int num1 = int.Parse(firstStr);

            Console.WriteLine("Enter second number");
            string secondStr = Console.ReadLine();
            int num2 = int.Parse(secondStr);
         
            string formatString1 = string.Format("{0}+{1}={2}", num1, num2, num1 + num2);
            Console.WriteLine(formatString1);

            string formatString2 = string.Format("{0}/{1}={2}", num1, num2, num1 / num2);
            Console.WriteLine(formatString2);

            string formatString3 = string.Format("{0}*{1}={2}", num1, num2, num1 * num2);
            Console.WriteLine(formatString3);

            Console.ReadLine();

        }
    }
}
