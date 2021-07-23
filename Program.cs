using System;
using System.Linq;

namespace DB8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateRandomArray(count: 100, maxValue: 100);
            Console.WriteLine("Не отсортированный: ");
            PrintArray(array);

            array.BucketSort(min: 0, max: 100);
            Console.WriteLine("Отсортированный: ");
            PrintArray(array);
        }

        static int[] CreateRandomArray(int count, int maxValue)
        {
            Random rnd = new Random();
            return Enumerable.Range(1, count).Select(x => rnd.Next(maxValue)).ToArray();
        }

        static void PrintArray(int[] array) =>
            Console.WriteLine(string.Join(' ', array));
    }
}
