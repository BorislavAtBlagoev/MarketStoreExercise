
namespace MarketStoreExercise.Models
{
    public class BronzeCard : Card
    {
        public BronzeCard(decimal purchaseValue, decimal turnover)
            : base(purchaseValue, turnover)
        {
        }

        public override void CalculateDiscountOfPurchase()
        {
            if (Turnover >= 100 && Turnover <= 300)
            {
                this._discountRate = 1;
                this.CalculateTotalPurchaseSum();
            }
            else if (Turnover > 300)
            {
                this._discountRate = 2.5;
                this.CalculateTotalPurchaseSum();
            }
            else
            {
                this._discountRate = 0;
                this.CalculateTotalPurchaseSum();
            }
        }
    }
}
