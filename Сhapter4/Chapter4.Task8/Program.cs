using System;
//
namespace Chapter4.Task8
{
    class Program
    {
        static void EvaluateEnum(System.Enum e)
        {

            Array enumData = Enum.GetValues(e.GetType());

            Console.WriteLine("as num {0}", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("name: {0}, value: {0:D}", enumData.GetValue(i));
            }

            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            ConsoleColor cc = ConsoleColor.Red;

            EvaluateEnum(cc);

            Console.ReadLine();
        }
    }
}
