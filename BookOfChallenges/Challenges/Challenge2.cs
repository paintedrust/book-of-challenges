using System;
namespace BookOfChallenges.Classes
{
    public static class Challenge2
    {
        public static void Run()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "heisenberg":
                    Console.WriteLine("You're God damn right");
                    break;
                case "bond":
                    Console.WriteLine("James Bond");
                    break;
                case "voldermort":
                    Console.WriteLine("Don't say the Name!");
                    break;
                default:
                    Console.WriteLine("Hello " + name);
                    break;
            }
        }
    }
}
