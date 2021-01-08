using System;

namespace Strong_number_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int factorialSum = 0;

            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum /= 10;
                int result = 1;

                for (int i = 1; i <= digit; i++)
                {
                    result *= i;
                }

                factorialSum += result;
            }

            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
