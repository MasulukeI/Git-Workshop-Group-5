using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Pentagon
    {
        private float a;
        private float r;
        public  float area;
        public float Perimeter;
        
      
        Pentagon(float a, float r)
        {
            this.a = a;
            this.r = r;
        
        
        }

        public void CalArea() {
            area = (5 * r * a) / 2;
            Console.WriteLine("Area:" + area.ToString());

        }
        public void CalPerimeter (){
            Perimeter = 5 * a;
            Console.WriteLine("Perimater:" + Perimeter.ToString());
        }



    }
}
