using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Pentagon
    {
        private int a;
        private int r;
        public  float area;
        public float Perimeter;

        Pentagon() {
            Inputs();
            CalArea();
            CalPerimeter();
        }
        Pentagon(int a, int r)
        {
            this.a = a;
            this.r = r;
        }

        public void CalArea() {
            area = (5 * r * a) / 2;
            Console.WriteLine("Area:" + area.ToString());

        }
        public void Inputs() {
            Console.WriteLine("Enter r : ");
            r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a : ");
            a = Int32.Parse(Console.ReadLine());

        }
        public void CalPerimeter (){
            Perimeter = 5 * a;
            Console.WriteLine("Perimater:" + Perimeter.ToString());
        }



    }
}
