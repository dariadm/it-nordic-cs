using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Collections;

namespace HomeApp4_3
{
    [Flags]
    enum ContainerType : byte
    {
        None = 0x0,
        One = 0x1,
        Five = 0x2,
        Twenty = 0x4
    }

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
            ContainerType containerTypeUsed = ContainerType.None;
            //System.Int32 containerTypeUsed;
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
                int curContType = containerTypes[i];
                if (rem != 0)
                    containerNumUsed[i] = Math.DivRem(rem, curContType, out rem);
                else
                {
                    containerNumUsed[i] = 0;
                    continue;
                }
                    

                // BAD SOLUTION!!!
                switch (curContType)
                {
                    case 20:
                        containerTypeUsed |= ContainerType.Twenty;
                        break;
                    case 5:
                        containerTypeUsed |= ContainerType.Five;
                        break;
                    case 1:
                        containerTypeUsed |= ContainerType.One;
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!");
                        break;
                }
            }

            // Checking if rem smaller then avaliable smallest type
            if (rem != 0)
            {
                // Adding one more smallest 
                containerNumUsed[containerNumUsed.Length - 1] = ++containerNumUsed[containerNumUsed.Length - 1];
            }

            // Output with bit
            System.Int32 containerTypeUsedI = (System.Int32)containerTypeUsed;
            //System.Collections.BitArray bits = new System.Collections.BitArray(containerTypeUsedI);
            //if (bits[0] == true)
            //    Console.WriteLine($"1л: {containerNumUsed[containerNumUsed.Length - 1]}");
            //if (bits[1] == true)
            //    Console.WriteLine($"5л: {containerNumUsed[containerNumUsed.Length - 2]}");
            //if (bits[2] == true)
            //    Console.WriteLine($"20л: {containerNumUsed[containerNumUsed.Length - 3]}");


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
