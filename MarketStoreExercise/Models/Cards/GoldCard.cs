
namespace MarketStoreExercise.Models
{
    public class GoldCard : Card
    {
        public GoldCard(decimal purchaseValue, decimal turnover) 
            : base(purchaseValue, turnover)
        {
        }

        public override void CalculateDiscountOfPurchase()
        {
            if (Turnover >= 100)
            {
                if (Turnover >= 800)
                {
                    this._discountRate = 10;
                }
                else if (Turnover < 800 && Turnover >= 100)
                {
                    this._discountRate = 2 + (int)(this.Turnover / 100);
                }
                else
                {
                    this._discountRate = 2;
                }

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
