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
            a = this.a;
            a = this.r;
        }

        public void CalArea(float a, float r) {
            area = (5 * r * a) / 2;

        }
        public void CalPerimeter (){
            Perimeter = 5 * a;
        }



    }
}
