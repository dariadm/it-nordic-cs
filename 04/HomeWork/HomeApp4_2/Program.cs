using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HomeApp4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("*******Container types*******");

            // Data
            double currentAmount;
            int[] containerTypes = { 1, 5, 20 };  // 
            int[] containerNumUsed = new int[containerTypes.Length];

            // Reading user's amount
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");
            currentAmount = ReadAmount();

            // Rounding amount if necessary
            int currentAmountI = (int)Math.Ceiling(currentAmount);

            // Sorting containter types
            Array.Sort(containerTypes);
            Array.Reverse(containerTypes);

            // Counts
            int rem = currentAmountI;
            for (uint i = 0; i < containerTypes.Length; ++i)
            {
                if (rem != 0)
                    containerNumUsed[i] = Math.DivRem(rem, containerTypes[i], out rem);
                else
                    containerNumUsed[i] = 0;
            }

            // Checking if rem smaller then avaliable smallest type
            if (rem != 0)
            {
                // Adding one more smallest 
                containerNumUsed[containerNumUsed.Length - 1] = ++containerNumUsed[containerNumUsed.Length - 1];
            }

            Console.WriteLine("Вам потребуются следующие контейнеры:");
            for (uint i = 0; i < containerTypes.Length; ++i)
            {
                int curType = containerTypes[i];
                int curNum = containerNumUsed[i];
                if (curNum != 0)
                    Console.WriteLine($"{curType}л: {curNum} шт.");
            }
        }

        // Reading age
        static double ReadAmount()
        {
            double amount;

            while (true)
            {
                bool isDouble = double.TryParse(Console.ReadLine(), out amount);
                if ((isDouble) && (amount > 0))
                    break;

                Console.WriteLine("Wrong value! ");
            }

            return amount;
        }
    }
}
