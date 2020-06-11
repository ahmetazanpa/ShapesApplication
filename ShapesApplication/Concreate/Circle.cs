using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesApplication
{
    public class Circle :IShape
    {
        private Color _color;
        private int _radius;

        public Circle(Color color, int radius)
        {
            _color = color;
            _radius = radius;
        }

        public int Area()
        {
            return Convert.ToInt32(Math.PI * _radius * _radius);
        }

        public string Draw()
        {
            return _color + " - Meter : " + Area();
        }
    }
}
