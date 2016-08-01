using System;
using System.Collections.Generic;

namespace PolymorphismStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(15, 10, 10, 20),
                new Rectangle(15, 10, 10, 20),
                new Triangle(15, 10, 10, 20, 5)
            };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
