using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Collections.Generic;

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

            Console.WriteLine("***********Checking correct brackets order***********");

            string userString;
            var openingBrackets = new Stack<char>();
            bool isStringCorrect = true;

            Console.WriteLine("Please, enter your string:");
            userString = Console.ReadLine();

            // Finding brackets in string
            foreach (char sym in userString)
            {
                // If found opening bracket, save
                if ((sym == '(') || (sym == '['))
                    openingBrackets.Push(sym);

                // If found closing bracket, check 
                if (sym == ')')
                {
                    // If openingBrackets is empty
                    if(openingBrackets.Count == 0)
                    {
                        isStringCorrect = false;
                        break;
                    }

                    // Looking for pair in stack
                    if (openingBrackets.Pop() != '(')
                    {
                        isStringCorrect = false;
                        break;
                    }
                }

                if (sym == ']')
                {
                    // If openingBrackets is empty
                    if (openingBrackets.Count == 0)
                    {
                        isStringCorrect = false;
                        break;
                    }

                    // Looking for pair in stack
                    if (openingBrackets.Pop() != '[')
                    {
                        isStringCorrect = false;
                        break;
                    }
                }
            }

            // If opening brackets without pair left 
            if (openingBrackets.Count != 0)
                isStringCorrect = false;

            // Writing the answer 
            if (isStringCorrect)
                Console.WriteLine("The string is correct");
            else
                Console.WriteLine("Brackets are not correct!");
        }
    }
}
