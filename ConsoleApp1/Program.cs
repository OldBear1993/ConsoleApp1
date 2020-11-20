using System;
using Spam01;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SpamBot Sp = new SpamBot();
            for (int y = 0; y <= 10000; y++)
            {
                Sp.Spam();
                Console.WriteLine(y + 1);
            }
        }
    }
}
