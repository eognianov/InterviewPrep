using System;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = makeAnagram(a, b);

            Console.WriteLine(res);
        }

        private static int makeAnagram(string a, string b)
        {
            int result = 0;

            int[] a_freq = new int[26];
            int[] b_freq = new int[26];

            foreach (var ch in a)
            {
                int char_int = (int)ch;
                int position = char_int - (int)'a';
                a_freq[position]++;
            }

            foreach (var ch in b)
            {
                int char_int = (int)ch;
                int position = char_int - (int)'a';
                b_freq[position]++;
            }

            for (int i = 0; i < 26; i++)
            {
                int diff = Math.Abs(a_freq[i] - b_freq[i]);
                result += diff;
            }

            return result;
        }
    }
}
