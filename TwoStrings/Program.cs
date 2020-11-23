using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }

        private static string twoStrings(string s1, string s2)
        {
            var letters = s1.ToHashSet();

            foreach (var letter in s2)
            {
                if (letters.Contains(letter))
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
