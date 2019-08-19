using System;
//8. Стоврити енам Color з деякими кольорами як значеннями(Наприклад, Red = 1, Green = 2, etc...). Вивести на екран всі стрічки енаму з їх значеннями.(використай інформацію на сторінках 170 і 171)
namespace Chapter4.Task8
{
    class Program
    {
        enum EmpType : int
        {
            Back = 1,
            Yellow = 2,
            Orange = 3,
            Green = 4,
            Blue = 5,
            Red = 6,
            Cyan = 7,
        static void EvaluateEnum(System.Enum e)
        {
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} colors", enumData.Length);

            for(int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Nae: {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            EmpType e2 = EmpType.Red;
            EvaluateEnum(e2);

            Console.ReadLine();
        }
    }
}
