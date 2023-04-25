using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCircleArea
{
    internal class Rectangle
    {
        private double height;
        private double width;
        private double area;

        public Rectangle(double rectangleHeight, double rectangleWidth)
        {
            height = rectangleHeight;
            width = rectangleWidth;
        }

        public double calculateArea()
        {
            area = height * width;
            return area;
        }

        public void printArea()
        {
            Console.WriteLine("Rectangle area is: " + area);
        }
    }
}
