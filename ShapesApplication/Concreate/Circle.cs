using ShapesApplication.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesApplication
{
    public class Circle : Shape
    {
        private Color _color;
        private int _radius;

        public Circle(Color color, int radius)
        {
            _color = color;
            _radius = radius;
        }

        public override int Area()
        {
            return Convert.ToInt32(Math.PI * _radius * _radius);
        }

        public override void Draw()
        {
            Console.WriteLine("Circle : " + _color + " - Area Meter : " + Area());
        }
    }
}
