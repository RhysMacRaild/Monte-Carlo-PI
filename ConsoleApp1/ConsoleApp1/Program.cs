using System;

namespace Pi
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.printRadius();
            circle.checkPoints(10000000);
        }
    }
}
