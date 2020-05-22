using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Shapes
{
    class Rectangle : shape
    {
       
        public Rectangle(float h, float w)
        {
           this.Height = h;
            this.Width = w;
        }
       /* public void get()
        {
            Console.Write("Enter  Height :  ");
            
            height= float.Parse(Console.ReadLine());

            Console.Write("Enter Width : ");

            width = float.Parse(Console.ReadLine());
        }*/
        public float Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public float Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public override double CalculatePerimeter()
        {
            return 2*(height+width);
           
        }
        public override double CalculateArea()
        {
            return height* width;
        }
        public override string Draw()
        {
            return base.Draw()+"Rectangle";
        }
    }
}
