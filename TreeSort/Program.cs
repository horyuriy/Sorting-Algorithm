namespace TreeSort
{
    internal class Program
    {
        private static int[] TreeSort(int[] array)
        {
            var treeNode = new TreeSort(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeSort(array[i]));
            }

            return treeNode.Transform();
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());

            var a = new int[n];
            var random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0, 100);
            }

            Console.WriteLine("Random Array: {0}", string.Join(" ", a));

            Console.WriteLine("Sorted Array: {0}", string.Join(" ", TreeSort(a)));
        }
    }
}