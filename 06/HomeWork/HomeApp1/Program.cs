using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HomeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("***********Counting even digits in positive integer***********");

            int userNumber = 0;
            uint evenDigitsNumber = 0; 

            Console.WriteLine("Enter positive integer, not bigger then 2000000000:");

            while (true)
            {
                try
                {
                    userNumber = int.Parse(Console.ReadLine());

                    // Checking if positive
                    if (userNumber > 0)
                        break;

                    // If negative
                    Console.WriteLine("Wrong value! Try again");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Error {e.GetType()}! Try again");
                    continue;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Error {e.GetType()}! Try again");
                    continue;
                }
            }

            // Counting positive digits
            int rem = 0;
            int userNumberCopy = userNumber; 
            while (userNumberCopy != 0)
            {
                // Getting next digit
                rem = userNumberCopy / 10;

                // Checking if even
                if (rem % 2 == 0)
                    evenDigitsNumber += 1;

                // Reducing digit
                userNumberCopy = (userNumberCopy - rem) / 10; 
            }

            Console.WriteLine("The amount of even digits in number {0} is {1}", userNumber, evenDigitsNumber);
        }
    }
}
