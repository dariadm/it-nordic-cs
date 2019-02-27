using System;

namespace MyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter Data
            Console.WriteLine("Enter the 1st number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd nubmer:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator:");
            string curOperator = Console.ReadLine();

            // Counts
            double result;
            if (curOperator == "+")
                result = firstNumber + secondNumber;
            else if (curOperator == "-")
                result = firstNumber - secondNumber;
            else if (curOperator == "/")
                result = firstNumber / secondNumber;
            else if (curOperator == "*")
                result = firstNumber * secondNumber;
            else if (curOperator == "%")
                result = firstNumber % secondNumber;
            else if (curOperator == "^")
                result = Math.Pow(firstNumber, secondNumber);
            else
            {
                Console.WriteLine("Unknown operator! Impossible to get result");
                return; 
            }

            Console.WriteLine("THe result: {0}", result); 
        }
    }
}
