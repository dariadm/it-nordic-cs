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

            Console.WriteLine("***********Counting words starting with english letter 'A' in user's string***********");

            string userString = "";
            string[] wordsInUserString;
            uint wordsStartingWithA = 0;

            Console.WriteLine("Enter the string (must be not less then 2 words):");
            // Getting string and checking if enough words
            while (true)
            {
                userString = Console.ReadLine();

                wordsInUserString = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (wordsInUserString.Length >= 2)
                    break;

                Console.WriteLine("Not enough words! Try again and enter at less 2");
            }

            // Counting letter A
            foreach (string s in wordsInUserString)
            {
                if (s[0] == 'A' || s[0] == 'a')
                    wordsStartingWithA += 1; 
            }

            Console.WriteLine($"The number of words starting with english 'A' is: {wordsStartingWithA}");
        }
    }
}
