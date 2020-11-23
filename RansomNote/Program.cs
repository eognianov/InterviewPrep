using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }

        private static void checkMagazine(string[] magazine, string[] note)
        {
            var magazineDict = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (magazineDict.ContainsKey(word))
                {
                    magazineDict[word]++;
                }
                else
                {
                    magazineDict[word] = 1;
                }
            }

            foreach (var word in note)
            {
                if (!magazineDict.ContainsKey(word) || magazineDict[word]<1)
                {
                    Console.WriteLine("No");
                    return;
                }

                magazineDict[word]--;
            }

            Console.WriteLine("Yes");
        }
    }
}
