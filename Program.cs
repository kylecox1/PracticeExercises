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
                TriangleExplainer();
                                
                Console.Write("Continue? (y/n): ");
                playAgain = PlayAgain();
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
