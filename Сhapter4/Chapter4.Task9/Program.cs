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

            public int P;
            public int S;
            public void GetHeight(Point B, Point A)
            {
                Height = (B.X - A.X) + (B.Y - A.Y);
                
            }
            public void GetWidth(Point C, Point B)
            {
                Width = (C.X - B.X) + (C.Y - B.Y);
            }
            public void GetPerimetr()
            {
                P = 2 * (Height + Width);
            }
            public void GetSquare()
            {

                S = Height * Width;
            }
            public void DisplayRect()
            {
                Console.WriteLine($"Perimetr = {P},Square = { S}");
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(2, 4);
            A.Display();
            Point C = new Point(21, 17);
            C.Display();

            Rectangle rect = new Rectangle();
            Point B = new Point(A.X, C.Y);
            rect.bottomLeft = A;
            rect.topRight = C;

            rect.GetHeight(B, A);
            rect.GetWidth(C, B);
            rect.GetSquare();
            rect.GetPerimetr();

            rect.DisplayRect();
        }
    }
}
