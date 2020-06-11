using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesApplication
{
    public class Square : IShape
    {
        private Color _color { get; set; }
        private int _edge { get; set; }

        public Square(Color color, int edge)
        {
            _color = color;
            _edge = edge;
        }

        public int Area()
        {
            return _edge * _edge;
        }

        public string Draw()
        {
            return _color + " - Meter : " + Area();
        }
    }
}
