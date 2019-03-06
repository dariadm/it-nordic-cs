using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HomeApp4_1
{
    [Flags]
    enum ContainerType: byte
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
            ContainerType containerTypeAvaliable = ContainerType.None;
            int[] containerTypes = { 1, 5, 20 };

            // Reading user's amount
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");
            currentAmount = ReadAmount();

            // Rounding amount if necessary
            int currentAmountI = (int)Math.Ceiling(currentAmount);

            // Counting containter types
            Array.Sort(containerTypes);
            
            int type1 = 1;
            int type2 = 5;
            int type3 = 20;
            int rem = 0;
            int numType1 = 0;
            int numType5 = 0;
            int numType20 = 0;
            numType20 = Math.DivRem(currentAmountI, type3, out rem);
            if (rem != 0)
                numType5 = Math.DivRem(rem, type2, out rem);
            if(rem != 0)
                numType1 = Math.DivRem(rem, type1, out rem);
            if (rem != 0)
            {
                Console.WriteLine("Все плохо!!!");
                return;
            }


            if(numType20)

            Console.WriteLine("Вам потребуются следующие контейнеры:");
            if (numType20 != 0)
                Console.WriteLine($"20л: {numType20} шт.");
            if(numType5 != 0)
                Console.WriteLine($"5л: {numType5} шт.");
            if(numType1 != 0)
                Console.WriteLine($"1л: {numType1} шт.");
        }

        // Reading age
        static double ReadAmount()
        {
            double amount;

            while (true)
            {
                bool isDouble = double.TryParse(Console.ReadLine(), out amount);
                if((isDouble) && (amount > 0))
                    break;

                Console.WriteLine("Wrong value! ");
            }

            return amount;
        }

    }
}
