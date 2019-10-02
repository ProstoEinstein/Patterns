using Strategy.Interfaces;

namespace Strategy.Clasess
{
    /// <summary>
    /// Сортировка пузырьком
    /// </summary>
    sealed class BubbleSort : ISorting
    {
        public void Sort(int[] arr)
        {
            System.Console.WriteLine("Сортировка пузырьком");
            System.Console.WriteLine("До: {0}", string.Join(" ", arr));
            int temp = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}