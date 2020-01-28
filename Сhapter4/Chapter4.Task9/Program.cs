using System;
using System.Drawing;
//9. Створити структуру Point яка складається з координат X i Y(два числові поля). Створити структуру Rectangle, яка складається з двох точок(ліва нижня і права верхня). Написати методи для знаходження площі і периметру прямокутника. Формула для знаходження відстані між точкою А і В. AB = √(xb - xa)2 + (yb - ya)2
namespace Chapter4.Task9
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;
            }

            public void Display()
            {
                Console.WriteLine($"x = {x}, y = {y}");
            }
        }
        struct Rectangle
        {
            public int height;
            public int width;

            public Rectangle(Point a, Point c)
            {
                height = c.y - a.y;
                width = c.x - a.x;
            }

            public void GetPerimetr()
            {
                int P = 2 * (height + width);
                Console.WriteLine($"Perimetr rectangle = {P}");
            }

            public void GetSquare()
            {
                int S = height * width;
                Console.WriteLine($"Square rectangle = {S}");
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(2, 4);
            A.Display();
            Point C = new Point(21, 17);
            C.Display();

            Rectangle rect = new Rectangle(A, C);
            
            rect.GetSquare();
            rect.GetPerimetr();
        }
    }
}
