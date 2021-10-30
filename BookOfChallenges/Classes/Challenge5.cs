using System;
namespace BookOfChallenges.Classes
{
    public static class Challenge5
    {
        public static void Run()
        {
            Console.WriteLine("Enter your date of birth.");            

            Console.WriteLine("Year");
            Int32.TryParse(Console.ReadLine(), out int year);
            Console.WriteLine("\nMonth");
            Int32.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("\nDay");
            Int32.TryParse(Console.ReadLine(), out int day);

            try
            {
                var dob = new DateTime(year, month, day);
                var timeInDays = (DateTime.Now - dob).TotalDays;
                var timeInSeconds = (DateTime.Now - dob).TotalSeconds;
                var timeInHours = (DateTime.Now - dob).TotalHours;

                Console.WriteLine("\nYou've been alive for:");
                Console.WriteLine(String.Format("{0:n0}", timeInDays) + " Days");
                Console.WriteLine(String.Format("{0:n0}", timeInHours) + " Hours");
                Console.WriteLine(String.Format("{0:n0}", timeInSeconds) + " Seconds");
            }
            catch
            {
                Console.WriteLine("Please don't push it, just enter a valid day/month/year and make everyones life easier.\nThank you");
            }

            
        }
    }
}
