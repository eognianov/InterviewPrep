using System;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] rotLeft(int[] a, int d)
        {
            int n = a.Length;
            int[] array = new int[n];
            for (int i = 0; i<n; i++)
            {
                array[(i + (n - d)) % n] = a[i];
            }

            return array;
        }
    }
}
