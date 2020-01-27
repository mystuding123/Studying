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
            public Point topRight;
            public Point bottomLeft;
            public int Height;
            public int Width;


            public void CreateRectangle(Point C, Point A)
            {
                topRight = C;
                bottomLeft = A;
                CalculateHeight();
                CalculateWidth();
            }
            public void CalculateHeight()
            {
                Height = topRight.Y - bottomLeft.Y;

                Console.WriteLine($"Height rectangle = {Height}");
            }
            public void CalculateWidth()
            {
                Width = topRight.X - bottomLeft.X;
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

            rect.CreateRectangle(C, A);
            rect.GetSquare();
            rect.GetPerimetr();
        }
    }
}
