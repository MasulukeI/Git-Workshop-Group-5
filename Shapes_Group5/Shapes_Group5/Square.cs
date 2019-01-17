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
            int length = 0;
            int width = 0;
            Console.WriteLine("Provide the length of the square");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide the width of the square");
            width = Convert.ToInt32(Console.ReadLine());
     
            int area = 0;

            area = calcSquareArea(length, width);

            Console.WriteLine("the are is: " + area);
            Console.ReadLine();
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

