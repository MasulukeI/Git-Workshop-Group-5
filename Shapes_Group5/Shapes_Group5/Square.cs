using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Square
    {
        int area = 0;
        public Square()
        {

        }

        public int calcSquareArea(int length, int width)
        {

             area =length * width;
            return area;
        }

        public int getSquareArea()
        {
            return area;
        }
    }
}
}
