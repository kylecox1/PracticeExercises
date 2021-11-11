using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    class Square
    {
        private int sideLength;
        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        public Square(int sideLenth)
        {
            SideLength = sideLenth;
        }
        public static int CalculatePerimeter(int sideLength)
        {
            return 4 * sideLength;
        }
        public static int CalculateArea(int sideLength)
        {
            return sideLength * sideLength;
        }
    }
}
