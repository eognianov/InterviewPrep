using System;
using System.Linq;
using System.Text;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }

        private static long repeatedString(string s, long n)
        {
            long size = s.Length;
            long repeated = n/size;
            long left = n - (size * repeated);
            int extra = 0;

            int count = 0;
            for(int i = 0; i < size; i++){
                if(s[i] == 'a'){
                    ++count;
                }
            }

            for(int i = 0; i < left; i++){
                if(s[i] == 'a'){
                    ++extra;
                }
            }

            repeated = (repeated * count) + extra;

            return repeated;
        }
    }
}
