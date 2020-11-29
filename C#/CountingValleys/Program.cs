using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = CountingValleys(steps, path);

            Console.WriteLine(result);

        }

        private static int CountingValleys(int steps, string path)
        {
            int valleys = 0;
            int deepLevel = 0;
            bool isValley = false;

            foreach (var step in path.ToCharArray())
            {
                switch (step)
                {
                    case 'U':
                        if (isValley && deepLevel == -1)
                        {
                            valleys++;
                            isValley = false;
                        }

                        deepLevel++;
                        break;
                    case 'D':
                        if (deepLevel==0)
                        {
                            isValley = true;
                        }

                        deepLevel--;
                        break;
                }
            }
            return valleys;
        }
    }
}
