using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Rhombus
    {
        int _length;
        int _altitude;
        public Rhombus()
        {
            readRhombusInputs();
            getRhombusArea();
        }

        public void getRhombusArea()
        {
            Console.WriteLine( (_length * _altitude).ToString());
        }

        public void readRhombusInputs()
        {
            Console.WriteLine("Give the length of the rhombus");
            _length = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Give the altitude or height of the rhombus");
            _altitude = Convert.ToInt32( Console.ReadLine());
        }
    }
}
