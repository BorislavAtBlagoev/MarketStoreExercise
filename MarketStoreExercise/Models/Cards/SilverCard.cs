
namespace MarketStoreExercise.Models
{
    public class SilverCard : Card
    {
        public SilverCard(decimal purchaseValue, decimal turnover) 
            : base(purchaseValue, turnover)
        {
        }

        public override void CalculateDiscountOfPurchase()
        {
            if (Turnover > 300)
            {
                this._discountRate = 3.5;
                this.CalculateTotalPurchaseSum();
            }
            else
            {
                this._discountRate = 2;
                this.CalculateTotalPurchaseSum();
            }
        }
    }
}
