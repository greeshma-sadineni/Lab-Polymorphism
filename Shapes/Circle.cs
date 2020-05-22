using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
     class Circle:shape
    {

        public Circle(float radius)
        {
            this.Radius = radius;
            
        }
        public float Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;

            }
        }

        /*public void get()
        {
            Console.Write("Enter Radius :  ");

            radius = float.Parse(Console.ReadLine());
        }*/
        public override double CalculatePerimeter()
        {
            return 2 * 3.14F * radius;

        }
        public override double CalculateArea()
        {
            return 3.14F * radius * radius;
        }
        public override string Draw()
        {
            return base.Draw() +"Circle";
        }
    }
}

