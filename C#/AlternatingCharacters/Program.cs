using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }
        }

        private static int alternatingCharacters(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i]==s[i+1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
