using System;

using MarketStoreExercise.Contracts;

namespace MarketStoreExercise.IO
{
    public class Writer : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
