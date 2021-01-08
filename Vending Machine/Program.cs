using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string moneyReceived = Console.ReadLine();

            double coinSum = 0;

            while (moneyReceived != "Start")
            {
                double coin = double.Parse(moneyReceived);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    coinSum += coin;
                }

                else
                {

                    Console.WriteLine($"Cannot accept {coin}");
                }
                moneyReceived = Console.ReadLine();
            }

            string product = Console.ReadLine();
            while (product != "End")
            {
                double productPrice = 0;
                switch (product)
                {

                    case "Nuts":
                        productPrice = 2.0;
                        break;

                    case "Water":
                        productPrice = 0.7;
                        break;

                    case "Crisps":
                        productPrice = 1.5;
                        break;

                    case "Soda":
                        productPrice = 0.8;
                        break;

                    case "Coke":
                        productPrice = 1.0;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (productPrice <= coinSum)
                {
                    coinSum -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }

                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinSum:F2}");
        }
    }
}
