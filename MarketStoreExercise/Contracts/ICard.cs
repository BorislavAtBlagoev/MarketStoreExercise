
namespace MarketStoreExercise.Contracts
{
    public interface ICard
    {
        public decimal PurchaseValue { get; set; }
        public double DiscountRate { get; }
        public decimal Discount { get; }
        public decimal TotalSumOfPurchase { get; }
        void CalculateDiscountOfPurchase();
    }
}
