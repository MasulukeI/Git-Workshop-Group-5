using System;

namespace Shapes_Group5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(10, 10);
            Console.WriteLine(triangle1.area());
            Square S = new Square();
            Rhombus R = new Rhombus();
            Console.Read();
        }
    }
}
