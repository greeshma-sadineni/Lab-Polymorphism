using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Shapes
{
    public abstract class shape
    {
        protected float height, width, radius;
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();


        public virtual string Draw()
        {
            return $"I am shape ";
        }

    }
}

