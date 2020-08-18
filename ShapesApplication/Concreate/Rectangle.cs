using ShapesApplication.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesApplication
{
    public class Rectangle : Shape
    {
        private Color _color;
        private int _shorEdge;
        private int _longEdge;

        public Rectangle(Color color, int shortEdge, int longEdge)
        {
            _color = color;
            _shorEdge = shortEdge;
            _longEdge = longEdge;
        }

        public override int Area()
        {
            return _shorEdge * _longEdge;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle : "  + _color + " - Area Meter : " + Area());
        }
    }
}
