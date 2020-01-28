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

            public Point(int xPos, int yPos)
            {
                X = xPos;
                Y = yPos;
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

            public Rectangle(Point a, Point c)
            {
                Height = c.Y - a.Y;
                Width = c.X - a.X;
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
            Point a = new Point(2, 4);
            a.Display();
            Point c = new Point(21, 17);
            c.Display();

            Rectangle rect = new Rectangle(a, c);
           
            rect.GetSquare();
            rect.GetPerimetr();
        }
    }
}
