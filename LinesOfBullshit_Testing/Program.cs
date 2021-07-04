using System;

namespace LinesOfBullshit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string and I will reverse it.");
            string mystring = Console.ReadLine();
            char[] cReverse = mystring.ToCharArray();
            Console.WriteLine(cReverse);
            for(int i = cReverse.Length -1; i >= 0; i--)
            {
                Console.WriteLine(cReverse[i]);
            }
        }
    }
}
