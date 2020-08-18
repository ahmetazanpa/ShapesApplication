using ShapesApplication.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesApplication
{
    public class Square : Shape
    {
        private Color _color;
        private int _edge;

        public Square(Color color, int edge)
        {
            _color = color;
            _edge = edge;
        }

        public override int Area()
        {
            return _edge * _edge;
        }

        public override void Draw()
        {
            Console.WriteLine("Square : " + _color + " - Area Meter : " + Area());
        }
    }
}
