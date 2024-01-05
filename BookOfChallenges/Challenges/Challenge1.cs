using System;
using System.Collections.Generic;
using System.Linq;

namespace BookOfChallenges.Classes
{
    public static class Challenge1
    {
        //joke, punchline
        private static readonly Dictionary<string, string> _jokes = new Dictionary<string, string>()
        {
            { "!false", "It's funny because it's true." },
            { "How do you find Will Smith in the snow?", "Look for the Fresh Prints" },
            { "Why do cows wear bells?", "Becuase their horns don't work" },
            { "I tried to catch fog yesterday", "Mist"},
            { "Two guys walked into a bar", "The third guy ducked" },
            { "What did the police officer say to his belly-button?", "You’re under a vest" }
        };

        public static void Run()
        {
            //get random joke
            var random = new Random();
            var joke = _jokes.ElementAt(random.Next(0, _jokes.Count));

            Console.WriteLine(joke.Key);
            var keyPress = Console.ReadKey(true);
            
            while (keyPress.Key != ConsoleKey.Enter && keyPress.Key != ConsoleKey.Spacebar)
            {
                Console.WriteLine("\nPress space or enter to see the punchline\n");
                keyPress = Console.ReadKey(true);
            }

            Console.ForegroundColor = Constants.GetRandomColour();
            Console.WriteLine(joke.Value);
            Console.ResetColor();
        }
    }
}
