using System;
using System.Drawing;
//9. Створити структуру Point яка складається з координат X i Y(два числові поля). Створити структуру Rectangle, яка складається з двох точок(ліва нижня і права верхня). Написати методи для знаходження площі і периметру прямокутника. Формула для знаходження відстані між точкою А і В. AB = √(xb - xa)2 + (yb - ya)2
namespace Chapter4.Task9
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            public void Display()
            {
                Console.WriteLine($"x = {X}, y = {Y}");
            }
        }
        struct Rectangle
        {
            public int Height;
            public int Width;


            public void CreateRectangle(Point A, Point C)
            {
                Point topRight = A;
                Point bottomLeft = C;
                CalculateHeight(A, C);
                CalculateWidth(C, A);
            }
            public void CalculateHeight(Point A, Point C)
            {
                Height = C.Y - A.Y;

                Console.WriteLine($"Height rectangle = {Height}");
            }
            public void CalculateWidth(Point C, Point A)
            {
                Width = C.X - A.X;
                Console.WriteLine($"Width rectangle = {Width}");
            }
            public void GetPerimetr()
            {
                int P = 2 * (Height + Width);
                Console.WriteLine($"Perimetr rectangle = {P}");
            }
            public void GetSquare()
            {

                int S = Height * Width;
                Console.WriteLine($"Square rectangle = {S}");
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(2, 4);
            A.Display();
            Point C = new Point(21, 17);
            C.Display();

            Rectangle rect = new Rectangle();

            rect.CreateRectangle(A, C);
            rect.GetSquare();
            rect.GetPerimetr();
        }
    }
}
