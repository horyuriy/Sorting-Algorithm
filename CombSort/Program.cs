namespace CombSort
{
    internal class Program
    {
        static int[] GetRandomArray(int length, int minValue, int maxValue)
        {
            var r = new Random();
            var outputArray = new int[length];
            for (var i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = r.Next(minValue, maxValue);
            }

            return outputArray;
        }
        static void Main(string[] args)
        {
            var arr = GetRandomArray(15, 0, 10);
            Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", CombSorting.CombSort(arr)));
            Console.ReadLine();
        }
    }
}