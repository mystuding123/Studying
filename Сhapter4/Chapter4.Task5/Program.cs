using System;
using System.Linq;
//5. Створити масив з n чисел(n зчитати з консолі, масив також). вивести найбільше і найменше числа в масиві а також їх індекси.

namespace Chapter4.Task5
{
    class Program
    {
        static int ReadInt(string text)
        {
            Console.WriteLine(text);
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);

            return num;
        }

        static void Main(string[] args)
        {
            int firstNum = ReadInt("Enter lenght");
            int secondNum = ReadInt("Enter values");

            int[] array = new int[firstNum];
            int max = int.MinValue;
            int min = int.MaxValue;


            for (int i = 0; i < array.Length; i++)

            {
                array[i] = i * secondNum;
            }

            for (int i = 0; i < array.Length; i++)

            {
                if (array[i] > max)

                {
                    max = array[i];
                    Console.WriteLine("Array {0}", array[i]);
                }

                if (array[i] < min)

                {
                    min = array[i];
                }
            }

            Console.WriteLine("MaxValue {0}", max);
            Console.WriteLine("MinValue {0}", min);

            Console.ReadLine();
        }
    }
}
