using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCircleArea
{
    public class Circle
    {
        int radius;
        int diameter;
        double smallerCircleArea;
        double biggerCircleArea;

        public Circle(int smallerCircleRadius)
        {
            radius = smallerCircleRadius;
        }

        public double calculateSmallerCircleArae()
        {
            smallerCircleArea = Math.Pow(radius,2) * 3.14;

            return smallerCircleArea;
        }

        public double calculateBiggerCircleArea()
        {
            biggerCircleArea = smallerCircleArea * 2;
            return biggerCircleArea;
        }

        public double getSmallerCircleArea()
        {
            return smallerCircleArea;
        }

        public double getBiggerCircleArea()
        {
            return biggerCircleArea;
        }

        public void printCircleArea()
        {
            Console.WriteLine("Small circle Area: " + this.getSmallerCircleArea());
            Console.WriteLine("Big circle Area: " + this.getBiggerCircleArea());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of smaller circle: ");
            String circleRadius = Console.ReadLine();
            Circle circleObj = new Circle(Convert.ToInt32(circleRadius));
            circleObj.calculateSmallerCircleArae();
            circleObj.calculateBiggerCircleArea();
            circleObj.printCircleArea();
            Console.ReadKey();
        }
    }
}
