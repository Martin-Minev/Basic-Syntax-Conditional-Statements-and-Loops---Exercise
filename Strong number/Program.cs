using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = number;
            int currentDigit = 0;
            int factorialSum = 0;

            while (number != 0)
            {
                currentDigit = number % 10;     // 5 se vzima, ostawa 140
                number /= 10;                  // 140 se deli na 10 i ostawa 14

                int factorialCurrentDigit = 1;
                for (int i = 1; i <= currentDigit; i++)
                {
                    factorialCurrentDigit *= i;
                }
                factorialSum += factorialCurrentDigit;
            }

            string result = string.Empty;

            if (factorialSum == input)
            {
                result = "yes";
            }

            else
            {
                result = "no";
            }
            Console.WriteLine(result);
        }
    }
}
