using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsHelloworld
{
    public class Circle
    {

        private double radius;
        private double PI = 3.14159;
        public Circle(double radius)
        {
            this.radius = radius;
        }


        public Circle()
        {
            radius = 0.0;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }


        public double getArea()
        {
            return PI * radius * radius;
        }

        public double getDiameter()
        {
            return radius * 2;
        }


        public double getCircumference()
        {
            return 2 * PI * radius;
        }
    }
    class circle1
    {
        public static void Main(String[] args)
        {

            double radius;
            Console.WriteLine("Please enter the circle's radius");
            radius = double.Parse(Console.ReadLine());

            Circle c1 = new Circle(radius);

            Console.WriteLine("The area of the circle with radius of " + radius + " is " + c1.getArea()
                    + " with diameter of " + c1.getDiameter() + " and with circumference of " + c1.getCircumference());
        }
    }
}

