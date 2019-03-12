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

            Console.WriteLine("***********Counting days to get sum***********");

            int initialPayment = 0;
            double dayPercentOfIncome = 0;
            int desiredAmount = 0;
            int daysAmount = 0;

            // Getting data 
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter the initial payment:");
                    initialPayment = int.Parse(Console.ReadLine());
                    if (initialPayment <= 0)
                    {
                        Console.WriteLine("Wrong value! Try again");
                        continue;
                    }

                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the day percent of income as decimal with \".\" :");
                    string tempDayPercentOfIncome = Console.ReadLine();
                    if (tempDayPercentOfIncome.IndexOf('.') == -1)
                    {
                        Console.WriteLine("Wrong format! Try again");
                        continue;
                    }
                    dayPercentOfIncome = double.Parse(tempDayPercentOfIncome);
                    if (dayPercentOfIncome <= 0)
                    {
                        Console.WriteLine("Wrong value! Try again");
                        continue;
                    }

                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the desired amount:");
                    desiredAmount = int.Parse(Console.ReadLine());
                    if (desiredAmount <= 0)
                    {
                        Console.WriteLine("Wrong value! Try again");
                        continue;
                    }

                    break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error {e.GetType()}! Finish");
                throw;
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error {e.GetType()}! Finish");
                throw;
            }

            // Counting days
            double currentSum = (double)initialPayment; 
            while(currentSum <= desiredAmount)
            {
                currentSum += currentSum * dayPercentOfIncome;
                daysAmount += 1; 
            }

            Console.WriteLine($"The amount of days to get desired amount is {daysAmount}");
        }
    }
}
