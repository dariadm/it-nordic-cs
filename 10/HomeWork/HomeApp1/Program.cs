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

            Console.WriteLine("***********Your age in 4 years***********");

            PersonalInfo[] usersInfo = new PersonalInfo[3];

            // Reading users' info
            for(uint i = 0; i < 3; ++i)
            {
                // Initialization
                usersInfo[i] = new PersonalInfo();

                Console.WriteLine($"Enter name {i}:");
                usersInfo[i].Name = Console.ReadLine();

                Console.WriteLine($"Enter age (from 0 to 150) {i}:");
                usersInfo[i].Age = ReadAge();
            }

            // Writing users' info
            for(uint i = 0; i < 3; ++i)
            {
                Console.WriteLine(usersInfo[i].PersonalInfoString);
            }

            Console.ReadKey();
        }

        // Reading age
        static byte ReadAge()
        {
            byte age;

            while (true)
            {
                try
                {
                    age = byte.Parse(Console.ReadLine());

                    if (age >= 0 && age <= 150)
                        break;
                    else
                        throw new FormatException();
                }

                catch(FormatException e)
                {
                    Console.WriteLine("Format of the age is wrong! Please, enter the number from 0 to 150");
                    continue;
                }

                catch(OverflowException e)
                {
                    Console.WriteLine("Format of the age is wrong! Please, enter the number from 0 to 150");
                    continue;
                }
            }

            return age;
        }
    }
}
