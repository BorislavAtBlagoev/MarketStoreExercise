using System;

using MarketStoreExercise.Contracts;

namespace MarketStoreExercise.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
