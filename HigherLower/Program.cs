using System;

namespace HigherLower
{
    public class Program
    {
        public class GuessMachine
        {
            bool guessing = true;
            int currentGuess = 50;
            int divisor = 2;

            public void Guess()
            {
                while(guessing)
                {
                    int guessDifference = 50/divisor;
                    if (guessDifference < 1)
                    {
                        guessDifference = 1;
                    }
                    else
                    {
                        guessDifference = guessDifference;
                    }
                    Console.WriteLine("Is your number higher or lower than " + currentGuess + ", or am I correct?");
                    string higherLowerCorrect = Console.ReadLine().ToLower();
                    
                    if (higherLowerCorrect == "higher")
                    {
                        currentGuess += guessDifference;
                    }
                    else if (higherLowerCorrect == "lower")
                    {
                        currentGuess -= guessDifference;
                    }
                    else if (higherLowerCorrect == "correct")
                    {
                        Console.WriteLine("That's because I am a computer. Beep Boop");
                        guessing = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    divisor = divisor*2;
                }
            }
        }
        public static void Main()
        {
            GuessMachine guessMachine = new GuessMachine();
            Console.WriteLine("Would you like to play the higher or lower game?(Yes/No)");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                guessMachine.Guess();
            }
            else
        {
            Console.WriteLine("Oh.. well, ok. Goodbye!");
        }
        }
    }
}