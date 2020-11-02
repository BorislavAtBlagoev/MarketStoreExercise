using System;
using System.Text;

using MarketStoreExercise.Contracts;

namespace MarketStoreExercise.Models
{
    public class ConsolePrint : IPrintable
    {
        public void Print(ICard card)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Purchase value: ${card.PurchaseValue}");
            sb.AppendLine($"Discount rate: {card.DiscountRate:F1}%");
            sb.AppendLine($"Discount: ${card.Discount:F2}");
            sb.AppendLine($"Total: ${card.TotalSumOfPurchase}");

            Console.WriteLine(sb.ToString().TrimEnd());

        }
    }
}
