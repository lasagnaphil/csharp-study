
using System;

namespace PolymorphismStudy
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height)
        { }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            for (int j = 0; j <= 20; j++)
            {
                for (int i = 0; i <= 30; i++)
                {
                    if (i >= X - Width/2 && i <= X + Width/2 && j >= Y - Height/2 && j <= Y + Height/2)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}