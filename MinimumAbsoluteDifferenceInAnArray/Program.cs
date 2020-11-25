using System;

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

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i==j)
                    {
                        continue;
                    }

                    int diff = Math.Abs(arr[i] - arr[j]);

                    if (diff==1)
                    {
                        return diff;
                    }

                    if (diff<minDiff)
                    {
                        minDiff = diff;
                    }
                }
            }

            return minDiff;
        }
    }
}
