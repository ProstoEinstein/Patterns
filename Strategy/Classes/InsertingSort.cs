using Strategy.Interfaces;

namespace Strategy.Clasess
{
    /// <summary>
    /// Сортировка вставками
    /// </summary>
    sealed class InsertingSort : ISorting
    {
        public void Sort(int[] arr)
        {
            System.Console.WriteLine("Сортировка вставками");
            System.Console.WriteLine("До: {0}", string.Join(" ", arr));
            int temp = 0;
            int j = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i;
                while (j > 0 && temp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
        }
    }
}