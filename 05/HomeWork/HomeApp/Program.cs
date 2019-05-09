using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HomeApp
{
    class Program
    {
        enum Figure
        {
            Circle = 1,
            EquTriangle = 2,
            Rectangle = 3,
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("***********Counting area of figures***********");

            Console.WriteLine("Enter the type of Figure (1 - Circle, 2 - Equilateral Triangle, 3 - Rectangle):");
            uint currentFigureType = uint.Parse(Console.ReadLine());

            switch(currentFigureType)
            {
                case 1:
                    CountCircleArea();
                    break;
                case 2:
                    CountTriangleArea();
                    break;
                case 3:
                    CountRectangleArea();
                    break;
                default:
                    throw new Exception("Unknown type of Figure");
            }

            Console.ReadKey();
        }

        static void CountCircleArea()
        {
            Console.WriteLine("Enter the diameter:");

            try
            {
                double currentDiameter = double.Parse(Console.ReadLine());
                double currentRadius = currentDiameter / 2;

                if (currentDiameter <= 0 || currentRadius <= 0)
                    throw new FormatException();

                Console.WriteLine($"Area of Circle is: {Math.PI * currentRadius * currentRadius}");
                Console.WriteLine($"Perimeter of Circle is: {2 * Math.PI * currentRadius}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("You entered wrong format data! Must be positive double numbers");
                return;
            }
        }

        static void CountTriangleArea()
        {
            Console.WriteLine("Enter the side:");

            try
            {
                double currentSide = double.Parse(Console.ReadLine());
                if (currentSide <= 0)
                    throw new FormatException();

                Console.WriteLine($"Area of Equilateral Triangle is: {Math.Sqrt(3) * currentSide * currentSide / 4}");
                Console.WriteLine($"Perimeter of Equilateral Triangle is: {3 * currentSide}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("You entered wrong format data! Must be positive double numbers");
                return;
            }
        }

        static void CountRectangleArea()
        {
            try
            {
                Console.WriteLine("Enter the height:");
                double currentHeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width:");
                double currentWidth = double.Parse(Console.ReadLine());

                if (currentHeight <= 0 || currentWidth <= 0)
                    throw new FormatException();

                Console.WriteLine($"Area of Rectangle is: {currentHeight * currentWidth}");
                Console.WriteLine($"Perimeter of Rectangle is: {2 * (currentWidth + currentHeight)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("You entered wrong format data! Must be positive double numbers");
                return;
            }
        }
    }
}
