using System;

namespace integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name two integers");

            string value1;
            string value2;

            value1 = Console.ReadLine();
            value2 = Console.ReadLine();

            if (value1.Equals(value2))
            {
                Console.WriteLine("your numbers are equal");
            }
            else
            {
                Console.WriteLine("Your two integers are not equal");
            }
        }
    }
}
