using System;

namespace HigherLower
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Would you like to play the higher or lower game?(Yes/No)");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                Console.WriteLine("Ok one sec lemme get it ready");
            }
            else
        {
            Console.WriteLine("Oh.. well, ok. Goodbye!");
        }
        }
    }
}