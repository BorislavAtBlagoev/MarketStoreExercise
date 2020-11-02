using System;

using MarketStoreExercise.Contracts;
using MarketStoreExercise.Utilities;

namespace MarketStoreExercise.Models
{
    public abstract class Card : ICard
    {
        private decimal _purchaseValue;
        private decimal _turnover;
        private decimal _discount;
        private decimal _totalSumOfPurchase;

        protected double _discountRate;

        protected Card(decimal purchaseValue, decimal turnover)
        {
            this.PurchaseValue = purchaseValue;
            this.Turnover = turnover;
        }

        public decimal PurchaseValue
        {
            get => this._purchaseValue;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.INVALID_PURCHASE_VALUE);
                }

                this._purchaseValue = value;
            }
        }
        public decimal Turnover
        {
            get => this._turnover;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.INVALID_TURNOVER);
                }

                this._turnover = value;
            }
        }
        public double DiscountRate => this._discountRate;
        public decimal Discount => this._discount;
        public decimal TotalSumOfPurchase => this._totalSumOfPurchase;

        protected void CalculateTotalPurchaseSum()
        {
            this._discount = this.PurchaseValue * (decimal)(this._discountRate / 100);
            this._totalSumOfPurchase = this.PurchaseValue - this._discount;
        }
        public abstract void CalculateDiscountOfPurchase();
    }
}
