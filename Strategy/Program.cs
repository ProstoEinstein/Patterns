using System;
using System.Linq;
using Strategy.Clasess;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyClient client = new StrategyClient();
            Random r = new Random();
            int[] arr = new int[10];
            arr = arr.Select(x => x = r.Next(-99, 100)).ToArray();

            client.SetStrategy(new SelectionSort());
            client.ExecuteStrategy(arr);

            arr = arr.Select(x => x = r.Next(-99, 100)).ToArray();
            client.SetStrategy(new InsertingSort());
            client.ExecuteStrategy(arr);

            arr = arr.Select(x => x = r.Next(-99, 100)).ToArray();
            client.SetStrategy(new BubbleSort());
            client.ExecuteStrategy(arr);
        }
    }
}
