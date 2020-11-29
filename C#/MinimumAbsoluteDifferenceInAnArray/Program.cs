using System;
using System.Linq;

namespace MinimumAbsoluteDifferenceInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int result = minimumAbsoluteDifference(arr);

            Console.WriteLine(result);
        }

        private static int minimumAbsoluteDifference(int[] arr)
        {
            int minDiff = int.MaxValue;
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                minDiff = Math.Min(minDiff, Math.Abs(arr[i] - arr[i - 1]));
            }
            return minDiff;
        }
    }
}
