using System;

namespace Login_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            int counter = 0;

            while (true)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword != password)
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            }
        }
    }
}
