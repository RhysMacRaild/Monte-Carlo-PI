using System;
using System.Collections.Generic;
using System.Text;

namespace Pi
{
    class Circle
    {
        Random random;
        private double radius;
        private int inCirlce;
        private int outCircle;
        public Circle()
        {
            radius = 1;
            inCirlce = 0;
            outCircle = 0;
            random = new Random();
        }

        public void printRadius()
        {
            Console.WriteLine("Radius: {0}", radius);
        }

        public void checkPoints(int numberOfIterations)
        {
            for (int i = 0; i <= numberOfIterations; i++)
            {
                (double, double) coordinates = generatePoint();
                boundaryCheck(coordinates.Item1, coordinates.Item2);
            }

            double ratioInCircle = (double) numberOfIterations / (double) this.inCirlce;
            double tmp = ratioInCircle / 4;
            double pi_estimate = 1 / tmp;

            Console.WriteLine("Pi Estimate: {0}", pi_estimate.ToString("N8"));
        }

        private (double, double) generatePoint()
        {
            double x = this.random.NextDouble();
            double y = this.random.NextDouble();
            return (x, y);
        }

        private void boundaryCheck(double x, double y)
        {
            if (Math.Pow(x,2) + Math.Pow(y,2) <= this.radius)
            {
                this.inCirlce++;
            }
            else
            {
                this.outCircle++;
            }
        }
    }
}
