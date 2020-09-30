using System;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int c = 0;
            char lastChar = ' ';

            for(int i = 0; i < input.Length; i++)
            {
                if(i == 0)
                {
                    lastChar = input[i];
                    c++;
                }
                else
                {
                    if(input[i] == lastChar)
                    {
                        c++;
                        if(c == 7)
                        {
                            break;
                        }
                    }
                    else
                    {
                        lastChar = input[i];
                        c = 1;
                    }
                }
            }

            if(c == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
