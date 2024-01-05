using System;
using System.Collections.Generic;
using BookOfChallenges.Classes;

namespace BookOfChallenges
{
    class Program
    {
        private static readonly List<string> _challenges = new List<string>()
        {
            "Tell me a joke",
            "What is your name?",
            "Basic Geometry",
            "Are we there yet?",
            "How long have you been alive?",
            "Test your timing skills"
        };

        private delegate void Run();


        static void Main(string[] args)
        {
            ConsoleKeyInfo challenge;

            do
            {
                Console.WriteLine("The little book of programming challenges");
                Console.WriteLine("-----------------------------------------");

                for (var i = 0; i < _challenges.Count; i++)
                {
                    //separated to avoid confusion
                    Console.Write(i + 1); 
                    Console.WriteLine(") " + _challenges[i]);
                }

                Console.WriteLine("\nEnter a number to play a challenge\n");
                challenge = Console.ReadKey();
                Console.WriteLine("\n");

                try
                {
                    CalculateChallenge(challenge.Key);
                } catch
                {
                    Console.Clear();
                    Console.WriteLine("Enter a number or press q to quit.\n");
                }
            }
            while (challenge.Key != ConsoleKey.Q);
                
        }

        private static void CalculateChallenge(ConsoleKey key) {
            Run challenge = InvalidEntry;

            switch (key)
            {
                case ConsoleKey.D1:
                    challenge = Challenge1.Run;
                    break;
                case ConsoleKey.D2:
                    challenge = Challenge2.Run;
                    break;
                case ConsoleKey.D3:
                    challenge = Challenge3.Run;
                    break;
                case ConsoleKey.D4:
                    challenge = Challenge4.Run;
                    break;
                case ConsoleKey.D5:
                    challenge = Challenge5.Run;
                    break;
                case ConsoleKey.D6:
                    challenge = Challenge6.Run;
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
            }

            ConsoleKeyInfo repeat;

            do
            {
                challenge.Invoke();
                //System.Threading.Thread.Sleep(1000);
                Console.ReadKey();
                Console.WriteLine("\nSpace to run again or back to menu with any other key...\n");
                repeat = Console.ReadKey(true);
            }
            while (repeat.Key == ConsoleKey.Spacebar);

            Clear();

        }

        private static void InvalidEntry()
        {
            throw new Exception();
        }

        private static void Clear()
        {
            Console.Clear();
        }
    }
}