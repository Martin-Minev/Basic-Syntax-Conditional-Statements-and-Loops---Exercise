using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string correctPassword = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                correctPassword += userName[i];
            }
            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();

                if (correctPassword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");

                    break;
                }
                if (i <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {userName} blocked!");
                }
            }
        }
    }
}
