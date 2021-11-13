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
                TwelveDaysOfChristmasSinger();

                Console.Write("Continue? (y/n): ");
                playAgain = PlayAgain();
                Console.Clear();
            } while (playAgain == true);
            Console.WriteLine("Thanks for playing. Press any key to exit.");
            Console.ReadKey();
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

        // Exercise 31
        public static void DisplayNumberAtIndex()
        {
            int[] array = { 2, 8, 0, 24, 51 };
            Console.Write("Enter an index of the array: ");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            if (index < 0 || index > 4)
            {
                Console.WriteLine("That is not a valid index.");
            }
            else
            {
                Console.WriteLine($"The value at index {index} is {array[index]}.");
            }
        }

        //Excercise 32
        public static void DisplayIndexOfNumber()
        {
            int[] array = { 2, 8, 0, 24, 51 };
            Console.Write("Enter an number: ");
            string input = Console.ReadLine();
            int selection;
            if (!int.TryParse(input, out selection))
            {
                Console.WriteLine("Please enter an integer number only.");
            }
            else if (!array.Contains(selection))
            {
                Console.WriteLine("That number was not in the array.");
            }
            else
            {
                Console.WriteLine($"The number {selection} is located at array position " +
                    $"{Array.IndexOf(array, selection)}.");
            }
        }

        // Exercise 33
        public static void CustomizeArray()
        {

            int[] array = { 2, 8, 0, 24, 51 };
            bool playAgain = true;
            do
            {
                bool validIndex = false;
                int selection;
                do
                {
                    Console.Write("Enter an index of the array: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out selection))
                    {
                        Console.WriteLine("Please enter an integer number only.");
                    }
                    else if (selection < 0 || selection > array.Length - 1)
                    {
                        Console.WriteLine("That was out of range");
                    }
                    else
                    {
                        validIndex = true;
                    }
                } while (!validIndex);

                Console.Write($"The value at index {selection} is {array[selection]}. " +
                    $"Would you like to change it? (y/n)? ");

                bool changeIt = true;
                changeIt = PlayAgain();
                if (changeIt)
                {

                    int replacementNumber;
                    bool validReplacement = false;
                    do
                    {
                        Console.Write($"Enter the new value at index {selection}: ");
                        string input = Console.ReadLine();
                        if (!int.TryParse(input, out replacementNumber))
                        {
                            Console.WriteLine("Please enter an integer number only.");
                        }
                        else
                        {
                            validReplacement = true;
                        }
                    } while (!validReplacement);

                    array[selection] = replacementNumber;
                    Console.WriteLine($"The value at index {selection} is now {array[selection]}.");
                }

                Console.Write("Would you like to continue (y/n)? ");
                playAgain = PlayAgain();
            } while (playAgain);
        }

        // Exercise 34
        public static void ModifyArray()
        {
            bool playAgain = true;
            int[] array = { 16, 32, 64, 128, 256 };
            do
            {
                Console.Write("Enter a command (half/double): ");
                string input = Console.ReadLine();
                if (input.ToLower().Trim() == "half")
                {
                    int i = 0;
                    foreach (int number in array)
                    {
                        array[i] = number / 2;
                        i++;
                    }
                }
                else if (input.ToLower().Trim() == "double")
                {
                    int i = 0;
                    foreach (int number in array)
                    {
                        array[i] = number * 2;
                        i++;
                    }
                }
                Console.WriteLine($"The array now contatins: " +
                    $"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}");

                Console.Write("Would you like to continue (y/n)? ");
                playAgain = PlayAgain();
            } while (playAgain);
        }

        // Exercise 35
        public static void StringIndexer()
        {
            string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };
            Console.Write("Enter two indices: ");
            string input = Console.ReadLine();
            int[] userSelections = input.Split(' ').Select(int.Parse).ToArray();
            if (userSelections.Length > 2)
            {
                Console.WriteLine("That's more that two.");
            }
            int userValue = userSelections[0];
            int userLetter = userSelections[1];
            try
            {
                Console.WriteLine($"The value at index {userValue} is { animals[userValue] }. " +
                    $"The letter at index {userLetter} is { animals[userValue].ToArray()[userLetter] }.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Those are not valid indices.");
            }
        }

        // Exercise 36
        public static void TwelveDaysOfChristmasSinger()
        {
            int[] numbers = { 12, 11, 10, 9, 8 };
            string[] actors = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping",
                "Ladies Dancing", "Maids a-Milking" };
            Console.Write("Enter a command (sing/quit): "); ;
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (input.Trim().ToLower() == "sing")
            {
                int i = 0;
                foreach (int number in numbers)
                {
                    Console.WriteLine($"{number} {actors[i]}");
                    i++;
                }
            }
        }
    }
}
