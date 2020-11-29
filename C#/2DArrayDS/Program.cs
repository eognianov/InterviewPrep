using System;

namespace _2DArrayDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }

        private static int hourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;

            for (int row = 1; row < 5; row++)
            {
                for (int col = 1; col < 5; col++)
                {
                    int currSum = arr[row][col] + arr[row - 1][col - 1] + arr[row - 1][col] + arr[row - 1][col + 1] +
                                  arr[row + 1][col - 1] + arr[row + 1][col] + arr[row + 1][col + 1];

                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                    }
                }
            }

            return maxSum;
        }
    }
}
