using System;

namespace PracticeExercises
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            x = X;
            y = Y;
        }
        public static double CalculateDistance(double X, double Y)
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public static Point CalculateMidpoint(Point firstPoint, Point secondPoint)
        {
            return new Point((firstPoint.X + secondPoint.X) / 2, (firstPoint.Y + secondPoint.Y) / 2);
        }
    }
}
