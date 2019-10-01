using Strategy.Interfaces;

namespace Strategy
{
    sealed class StrategyClient
    {
        ISorting strategy;

        public void SetStrategy(ISorting strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy(int[] arr)
        {
            strategy.Sort(arr);
            System.Console.WriteLine("После: {0}", string.Join(" ", arr));
            System.Console.WriteLine("----------------------");
        }
    }
}