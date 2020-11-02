using System;

using MarketStoreExercise.IO;
using MarketStoreExercise.Models;
using MarketStoreExercise.Contracts;
using MarketStoreExercise.Utilities;

namespace MarketStoreExercise.Core
{
    public class Engine : IEngine
    {
        private IWriter _writer;
        private IReader _reader;
        private IPrintable _consolePrinter;
        public Engine()
        {
            this._writer = new Writer();
            this._reader = new Reader();
            this._consolePrinter = new ConsolePrint();
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    this._writer.WriteLine("Please insert type of card or Exit!");
                    this._writer.WriteLine("Types can be: Bronze, Silver or Gold.");
                    string input = this._reader.ReadLine();

                    if (!(input == "Bronze" || input == "Silver" || input == "Gold" || input == "Exit"))
                    {
                        throw new ArgumentException(ExceptionMessages.INVALID_INPUT);
                    }

                    if (input == "Exit")
                    {
                        Environment.Exit(0);
                    }

                    this._writer.WriteLine("Please enter the turnover for the previous month:");
                    if (!decimal.TryParse(this._reader.ReadLine(), out decimal turnover))
                    {
                        throw new InvalidOperationException(ExceptionMessages.INVALID_INPUT_FOR_TURNOVER);
                    }

                    this._writer.WriteLine("Please enter the purchase value:");
                    if (!decimal.TryParse(this._reader.ReadLine(), out decimal purchaseValue))
                    {
                        throw new InvalidOperationException(ExceptionMessages.INVALID_INPUT_FOR_PURCHASE);
                    }

                    if (input == "Bronze")
                    {
                        ICard card = new BronzeCard(purchaseValue, turnover);
                        card.CalculateDiscountOfPurchase();
                        this._consolePrinter.Print(card);
                    }
                    else if (input == "Silver")
                    {
                        ICard card = new SilverCard(purchaseValue, turnover);
                        card.CalculateDiscountOfPurchase();
                        this._consolePrinter.Print(card);
                    }
                    else if (input == "Gold")
                    {
                        ICard card = new GoldCard(purchaseValue, turnover);
                        card.CalculateDiscountOfPurchase();
                        this._consolePrinter.Print(card);
                    }

                }
                catch (Exception ex)
                {
                    this._writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
