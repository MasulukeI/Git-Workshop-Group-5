using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Group5
{
    class Ellipse
    {
        double a, b;

        public Ellipse() {
            this.getInputs();
        }
        public Ellipse(double a, double b) {
            this.a = a;
            this.b = b;
            }
        public void getArea() {
            Console.WriteLine("The area of the Ellipse is "+ (Math.PI*a*b).ToString());
        }

        public void getInputs() {

            Console.WriteLine("Please enter th ex-value: ");
           this.a= Convert.ToDouble(Console.Read());
            Console.WriteLine("Please enter th ex-value: ");
            this.b = Convert.ToDouble(Console.Read());

}
    }
}
