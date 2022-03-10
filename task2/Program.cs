using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 8, 98, 1, 100, 97, 2, 20 };
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
