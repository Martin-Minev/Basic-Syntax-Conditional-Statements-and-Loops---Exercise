using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double money = headset * (lostGames / 2);
            money += mouse * (lostGames / 3);
            money += keyboard * (lostGames / 6);
            money += display * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
