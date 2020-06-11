using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ShapesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(Color.Blue,10);
            Square square = new Square(Color.Green, 10);
            Rectangle rectangle = new Rectangle(Color.Red, 5, 8);
            Triangle triangle = new Triangle(Color.Yellow, 15, 7);

            Console.WriteLine("Circle : " + circle.Draw());
            Console.WriteLine("Square : " + square.Draw());
            Console.WriteLine("Rectangle  : " + rectangle.Draw());
            Console.WriteLine("Triangle  : " + triangle.Draw());
            Console.ReadKey();
        }
    }
}
