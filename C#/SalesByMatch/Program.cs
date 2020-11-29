using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

        }

        private static int sockMerchant(int n, int[] ar)
        {
            var socksByColor = new Dictionary<int, int>();

            foreach (var sock in ar)
            {
                if (!socksByColor.ContainsKey(sock))
                {
                    socksByColor[sock] = 1;
                    continue;
                }

                socksByColor[sock]++;
            }

            var result = 0;

            foreach (var key in socksByColor.Keys)
            {
                result += socksByColor[key] / 2;
            }

            return result;
        }
    }
}
