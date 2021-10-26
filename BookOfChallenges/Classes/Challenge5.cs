using System;
namespace BookOfChallenges.Classes
{
    public static class Challenge5
    {
        public static void Run()
        {
            string unit;

            do
            {
                Console.WriteLine("What unit do you want your speed calculated? mph/kph");
                unit = Console.ReadLine();

            } while (unit != "mph" && unit != "kph");

            var measurement = unit == "mph" ? "miles" : "kilometers";

            Console.WriteLine($"In {measurement}, how far do you need to go?");
            Int32.TryParse(Console.ReadLine(), out int distance);
            Console.WriteLine("How long before you need to be there (mins)");
            Int32.TryParse(Console.ReadLine(), out int minutes);

            double speed = distance / (minutes / 60);

            Console.WriteLine("You need to travel at " + speed + unit);
        }
    }
}
