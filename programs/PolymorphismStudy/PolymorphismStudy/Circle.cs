using System;

namespace PolymorphismStudy
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");

            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 30; i++)
                {
                    if ((i - X)*(i - X)/(float) (Width*Width)*4f + (j - Y)*(j - Y)/(float) (Height*Height)*4f <= 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}