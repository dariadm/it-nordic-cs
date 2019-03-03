using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace HomeApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("***********Your age in 4 years***********");

            string[] userNames = new string[3];
            byte[] userAges = new byte[3];

            // Reading users' names
            for (uint i = 0; i < userNames.Length; ++i)
            {
                Console.WriteLine($"Please, enter {i+1} name:");
                userNames[i] = Console.ReadLine();
            }
 
            // Reading users' ages
            for (uint i = 0; i < userAges.Length; ++i)
            {
                Console.WriteLine($"Please, enter {i+1} age (full age):");
                userAges[i] = ReadAge();
            }

            // Writing users' info
            Console.WriteLine("");
            Console.WriteLine("Counted age of users:");
            for (uint i = 0; i < userNames.Length; ++i)
            {
                Console.WriteLine("Name: {0}, age in 4 years: {1}", userNames[i], (userAges[i] + 4));
            }
            
            Console.ReadKey();
        }

        // Reading age
        static byte ReadAge()
        {
            byte age;

            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out age))
                    break;

                Console.WriteLine("Wrong value! ");
            }

            return age;
        }
    }
}
