namespace ShakerSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random sorting");
            Console.WriteLine("Enter the array elements:");
            var part = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[part.Length];
            for (int i = 0; i < part.Length; i++)
            {
                array[i] = Convert.ToInt32(part[i]);
            }
            Console.WriteLine("Sorted array: {0}", string.Join(", ", ShakerSort.ShakerSorts(array)));
            Console.ReadLine();
        }
    }
}