namespace ConsoleApp6
{
    internal class Program
    {
        public static void OptimizedBubbleSort(int[] arr)
        {
            int length = arr.Length;
            bool swapped;
            for (int i = 0; i < length - 1; i++)   // 10, 4, -5, -100, 4, 60 
            {                                      // 4, 10, -5, -100, 4, 60
                swapped = false;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                // no elements were swapped , the array is already sorted
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //int[] arr = { 10, 4, -5, -100, 4, 60 };
            //Console.WriteLine("original array = :");
            //PrintArray(arr);

            //OptimizedBubbleSort(arr);
            //PrintArray(arr);

            Range<int> intRange = new Range<int>(5, 10);
            Console.WriteLine("is in range" + intRange.IsInRange(15));
            Console.WriteLine("length of range = " + intRange.Length());

        }
    }
}
