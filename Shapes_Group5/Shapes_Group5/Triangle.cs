using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Triangle
    {
        public double _base;
        public double _height;

        public Triangle(double h, double b)
        {
            this._base = b;
            this._height = h;
        }

        public double area()
        {
            return (this._base / 2) *this._height;
        }
    }
}
