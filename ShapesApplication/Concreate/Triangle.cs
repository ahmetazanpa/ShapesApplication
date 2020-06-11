
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesApplication
{
    public class Triangle : IShape
    {
        private Color _color;
        private int _edge;
        private int _height;
        public Triangle(Color color, int edge, int heigth)
        {
            _color = color;
            _edge = edge;
            _height = heigth;
        }

        public int Area()
        {
            return (_edge * _height)/2;    
        }

        public string Draw()
        {
            return _color + " - Meter : " + Area();
        }
    }
}
