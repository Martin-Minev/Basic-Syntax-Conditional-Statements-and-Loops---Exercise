using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal pricePerPerson = 0;
            decimal totalPrice = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45m;
                            break;

                        case "Saturday":
                            pricePerPerson = 9.80m;
                            break;

                        case "Sunday":
                            pricePerPerson = 10.46m;
                            break;
                    }
                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.90m;
                            break;

                        case "Saturday":
                            pricePerPerson = 15.60m;
                            break;

                        case "Sunday":
                            pricePerPerson = 16.00m;
                            break;
                    }
                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15.00m;
                            break;

                        case "Saturday":
                            pricePerPerson = 20.00m;
                            break;

                        case "Sunday":
                            pricePerPerson = 22.50m;
                            break;
                    }
                    break;
            }

            if (type == "Students" && groupCount >= 30)
            {
                totalPrice = groupCount * pricePerPerson * 0.85m;
                Console.WriteLine("Total price: {0:F2}", totalPrice);
            }

            else if (type == "Students" && groupCount < 30)
            {
                totalPrice = groupCount * pricePerPerson;
                Console.WriteLine("Total price: {0:F2}", totalPrice);
            }

            else if (type == "Business" && groupCount >= 100)
            {
                totalPrice = (groupCount - 10m) * pricePerPerson;
                Console.WriteLine("Total price: {0:F2}", totalPrice);
            }

            else if (type == "Business" && groupCount < 100)
            {
                totalPrice = groupCount * pricePerPerson;
                Console.WriteLine("Total price: {0:F2}", totalPrice);
            }
            else if (type == "Regular" && groupCount >= 10 && groupCount <= 20)
            {
                totalPrice = groupCount * pricePerPerson * 0.95m;
                Console.WriteLine("Total price: {0:F2}", totalPrice);
            }

            else if (type == "Regular" && groupCount < 10 || groupCount > 20)
            {
                totalPrice = groupCount * pricePerPerson;
                Console.WriteLine("Total price: {0:F2}", totalPrice);
            }
        }
    }
}
