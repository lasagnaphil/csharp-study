using System;

namespace PolymorphismStudy
{
    public class Triangle : Shape
    {
        public int L { get; set; }

        public Triangle(int x, int y, int width, int height, int L) : base(x, y, width, height)
        {
            this.L = L;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            int left = X - Width/2;
            int top = Y - Height/2;
            int bottom = Y + Height/2;

            for (int j = 0; j <= 20; j++)
            {
                for (int i = 0; i < 30; i++)
                {
                    int relX = i - left;
                    int relY = j - top;
                    if (relX >= L*(float) (Height - relY)/(float) Height &&
                        relX <= Width - (Width - L)*(float) (Height - relY)/(float) Height &&
                        j >= top && j <= bottom)
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