using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(3f,4f);
            //Rectangle r = new Rectangle();
            //r.get();
            Console.WriteLine("Perimeter of rectangle is:"+ r.CalculatePerimeter());
          
            Console.WriteLine("Area of rectangle :"+r.CalculateArea());
           Console.WriteLine(r.Draw());
            Console.WriteLine();
            Circle c = new Circle(5f);
           
            //Circle c = new Circle();
            //c.get();
             Console.WriteLine("Perimeter of circle is:"+ c.CalculatePerimeter());
          
            Console.WriteLine("Area of circle :"+c.CalculateArea());
            Console.WriteLine(c.Draw());
            Console.ReadLine();
        }
    }
}
