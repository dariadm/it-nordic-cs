using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HomeApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("***********Printing user's string in lower case and reverse order***********");

            string userString = "";
            string[] wordsInUserString;

            Console.WriteLine("Enter the string:");
            // Getting string and checking if enough words
            while (true)
            {
                userString = Console.ReadLine();

                wordsInUserString = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (wordsInUserString.Length >= 1)
                    break;

                Console.WriteLine("The strig is empty! Try again");
            }

            // Converting
            string userStringConverted = "";
            for (int i = userString.Length - 1; i >= 0; --i)
            {
                userStringConverted += (userString.ToLower())[i];
            }

            Console.WriteLine(userStringConverted);
        }
    }
}
