using System;

namespace LogicConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LogicFizzBuzz();

            Console.WriteLine("Enter String Value:");

            string strInput = Console.ReadLine();
            ReverseString(strInput);

        }

        private static void ReverseString(string stringInput)
        {
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();

        }

        public static void LogicFizzBuzz()
        {
            int intMaxLength = 100;
            for (int i = 1; i <= intMaxLength; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
                else { }
            }
            Console.ReadKey();
        }
    }
}
