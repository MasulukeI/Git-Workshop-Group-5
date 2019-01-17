using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Rhombus
    {
        int _length;
        int _altitude;
        public Rhombus(int length, int altitude)
        {
            _length = length;
            _altitude = altitude;
        }

        public int getRhombuArea()
        {
            return _length * _altitude;
        }
    }
}
