using System;
using System.Collections.Generic;
using System.Text;

namespace Pi
{
    class Circle
    {
        private float Radius;
        public Circle(float radius)
        {
            Radius = radius;
        }

        public void printRadius()
        {
            Console.WriteLine("Radius: {0}", Radius);
        }
    }
}
