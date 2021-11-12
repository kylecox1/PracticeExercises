using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    class Triangle
    {
        private double side1Length;
        public double Side1Length
        {
            get { return side1Length; }
            set { side1Length = value; }
        }
        private double side2Length;
        public double Side2Length
        {
            get { return side2Length; }
            set { side2Length = value; }
        }
        private double side3Length;
        public double Side3Length
        {
            get { return side3Length; }
            set { side3Length = value; }
        }

        public Triangle(double side1Length, double side2Length, double side3Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
        }
        public static double CalculatePerimeter(double side1Length, double side2Length, double side3Length)
        {
            return side1Length + side2Length + side3Length;
        }
        public static long CalculateArea(double side1Length, double side2Length, double side3Length)
        {

            long s = ((long)side1Length + (long)side2Length + (long)side3Length) / 2;
            return (long)Math.Sqrt(s * (s - side1Length) * (s - side2Length) * (s - side3Length));
        }
    }
}
