using ShapesApplication.Abstract;
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
            Shape shape;
            shape = new Circle(Color.Blue, 10);
            shape.Draw();
            shape = new Rectangle(Color.Red, 5, 8);
            shape.Draw();
            shape = new Square(Color.Green, 10);
            shape.Draw();
            shape = new Triangle(Color.Yellow, 15, 7);
            shape.Draw();
            
            Console.ReadKey();
        }
    }
}
