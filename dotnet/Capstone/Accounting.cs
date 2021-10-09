using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Accounting
    {
        public decimal FeedMoney(decimal balance, decimal amountFed)
        {
            decimal newBalance = balance + amountFed;
            return newBalance;
        }

        public decimal PurchaseItem(decimal balance, decimal itemPrice)
        {
            decimal newBalance = balance - itemPrice;
            return newBalance;
        }

        public decimal CalculateTotalSales(decimal grossSales, decimal recentSale)
        {
            grossSales += recentSale;
            return grossSales;
        }

        public decimal MakeChange(decimal balance)
        {
            int balanceInCents = (int)(balance * 100);
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            int remainder = 0;

            if (balanceInCents == 0)
            {
                Console.WriteLine($"Your balance is 0, no change for you!");
            }
            else if (balanceInCents % 25 == 0)
            {
                quarterCount = balanceInCents / 25;
                Console.WriteLine($"Your change is {balance}, here are {quarterCount} quarters");
            }
            else
            {
                quarterCount = balanceInCents / 25;
                remainder = balanceInCents % 25;
                balanceInCents -= quarterCount * 25;

                if (balanceInCents % 10 == 0)
                {
                    dimeCount = balanceInCents / 10;
                    Console.WriteLine($"Your change is {balance}, here are {quarterCount} quarters and {dimeCount} dimes");
                }
                else
                {
                    dimeCount = balanceInCents / 10;
                    balanceInCents -= dimeCount * 10;
                    nickelCount = balanceInCents / 5;
                    Console.WriteLine($"Your change is {balance}, here are {quarterCount} quarters and {dimeCount} dimes and {nickelCount} nickels");
                }

            }

            return 0;
        }
    }
}
