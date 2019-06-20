using System;

namespace Chapter4.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Select number");
            String myStr = Console.ReadLine(); ;
            bool result = double.TryParse(myStr, out num);

            if (result == true)
            {
                Console.WriteLine(Math.Pow(num, 5));
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }
    }
}
