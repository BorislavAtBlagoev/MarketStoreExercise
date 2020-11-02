using MarketStoreExercise.Core;
using MarketStoreExercise.Contracts;

namespace MarketStoreExercise
{
    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
