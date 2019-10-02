using Strategy.Interfaces;

namespace Strategy.Clasess
{
    /// <summary>
    /// Сортировка выбором
    /// </summary>
    sealed class SelectionSort : ISorting
    {
        public void Sort(int[] arr)
        {
            System.Console.WriteLine("Сортировка выбором");
            System.Console.WriteLine("До: {0}", string.Join(" ", arr));
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}