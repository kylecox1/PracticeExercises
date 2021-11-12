using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {
                TriangleCollector();

                Console.Write("Continue? (y/n): ");
                playAgain = PlayAgain();
                Console.Clear();
            } while (playAgain == true);
            Console.WriteLine("Thanks for playing. Press any key to exit.");
            Console.ReadKey();
        }

        // Exercise 45
        public static void SquareExplainer()
        {
            Console.Write("Enter as side length: ");
            string input = Console.ReadLine();
            int userLength = int.Parse(input);
            int userArea = Square.CalculateArea(userLength);
            int userPerimeter = Square.CalculatePerimeter(userLength);
            Console.WriteLine($"The square has side length {userLength}. " +
                $"Its area is {userArea} and its perimeter is {userPerimeter}.");
        }

        // Exercise 46
        public static void TriangleExplainer()
        {
            Console.Write("Enter the side lengths of a triangle. First side: ");
            string input1 = Console.ReadLine();
            int userLength1 = int.Parse(input1);
            Console.Write("Next side: ");
            string input2 = Console.ReadLine();
            int userLength2 = int.Parse(input2);
            Console.Write("Final side: ");
            string input3 = Console.ReadLine();
            int userLength3 = int.Parse(input3);

            double userArea = Triangle.CalculateArea(userLength1, userLength2, userLength3);
            double userPerimeter = Triangle.CalculatePerimeter(userLength1, userLength2, userLength3);
            Console.WriteLine($"The triangle has side lengths {userLength1}, {userLength2}, " +
                $"and {userLength3}. Its area is {userArea} and its perimeter is {userPerimeter}.");
        }

        // Exercise 49
        public static void SquareCollector()
        {
            bool quit = false;
            List<Square> SquareList = new List<Square>();
            while (quit == false)
            {
                Console.Write("Enter a side length (q to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower().Trim() == "q")
                {
                    quit = true;
                    break;
                }
                int sideLength = int.Parse(input);
                if (sideLength <= 0)
                {
                    Console.WriteLine("That's too small.");
                }
                else
                {
                    SquareList.Add(new Square(sideLength));
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"You created { SquareList.Count } squares.");
            Console.WriteLine($"Largest: { SquareList.Max(s => s.SideLength) }");
            Console.WriteLine($"Smallest: { SquareList.Min(s => s.SideLength) }");

            List<int> AreaList = new List<int>();
            List<int> PerimeterList = new List<int>();
            foreach (var square in SquareList)
            {
                AreaList.Add(Square.CalculateArea(square.SideLength));
                PerimeterList.Add(Square.CalculatePerimeter(square.SideLength));
            }
            Console.WriteLine($"Average area: { AreaList.Average() }");
            Console.WriteLine($"Average perimeter: { PerimeterList.Average() }");
            Console.WriteLine("");
        }

        // Exercise 50
        public static void TriangleCollector()
        {
            bool quit = false;
            List<Triangle> TriangleList = new List<Triangle>();
            while (quit == false)
            {
                Console.Write("Enter the side lengths of a triangle separated by spaces (q to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower().Trim() == "q")
                {
                    quit = true;
                    break;
                }
                else
                {
                    string[] sides = input.Split(' ');
                    int side1Length = int.Parse(sides[0]);
                    int side2Length = int.Parse(sides[1]);
                    int side3Length = int.Parse(sides[2]);
                    TriangleList.Add(new Triangle(side1Length, side2Length, side3Length));
                }
            }
            Console.WriteLine("");
            List<long> AreaList = new List<long>();
            List<double> PerimeterList = new List<double>();
            foreach (var triangle in TriangleList)
            {
                AreaList.Add(Triangle.CalculateArea(triangle.Side1Length, triangle.Side2Length,
                    triangle.Side3Length));
                PerimeterList.Add(Triangle.CalculatePerimeter(triangle.Side1Length, triangle.Side2Length,
                    triangle.Side3Length));
            }
            Console.WriteLine($"Average area: { AreaList.Average() }");
            Console.WriteLine($"Average perimeter: { PerimeterList.Average() }");
            Console.WriteLine("");
        }

        public static bool PlayAgain()
        {
            bool isValidYesNo = false;
            do
            {
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "n")
                {
                    return false;
                }
                else if (input.Trim().ToLower() == "y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Please just enter a 'y' or an 'n'.");
                }
            } while (isValidYesNo == false);
            return false;
        }
    }
}
