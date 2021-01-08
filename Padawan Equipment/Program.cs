using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            double totalPriceLightsaber = priceLightsaber * Math.Ceiling(studentsCount * 1.10);
            double totalPriceRobe = priceRobe * studentsCount;

            double totalPriceBelt = priceBelt * studentsCount;
            int freeBeltsCount = studentsCount / 6;
            double freeBeltsPrice = freeBeltsCount * priceBelt;
            totalPriceBelt -= freeBeltsPrice;

            totalPrice = totalPriceBelt + totalPriceRobe + totalPriceLightsaber;

            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }

            else
            {

                Console.WriteLine($"Ivan Cho will need {(totalPrice - amountOfMoney):F2}lv more.");
            }
        }
    }
}
