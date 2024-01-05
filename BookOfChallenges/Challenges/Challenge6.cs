using System;
using System.Diagnostics;
using System.Threading;
namespace BookOfChallenges.Classes
{
    public static class Challenge6
    {
        public static void Run()
        {
            Console.CursorVisible = false;
            //option to make it a custom input length
            var secondCounter = 10;

            WriteLine("Lets see how good your timing is.");
            WriteLine($"After the countdown press any key after {secondCounter} seconds.", 500);
            WriteLine("3", 500);
            WriteLine("2", 1000);
            WriteLine("1", 1000);
            WriteLine("GO!", 1000);
            Stopwatch stopwatch = Stopwatch.StartNew();
            WriteLine(".", 1000);
            WriteLine("..", 1000);
            WriteLine("...", 1000);

            Console.ReadKey(true);
            Console.CursorVisible = true;
            stopwatch.Stop();

            var gap = Math.Abs(stopwatch.ElapsedMilliseconds - (secondCounter * 1000));

            if (gap < 100)
            {
                Console.WriteLine($"AMAZING! {secondCounter} seconds on the dot.");
                return;
            }

            decimal time = Convert.ToDecimal(stopwatch.ElapsedMilliseconds) / 1000;

            Console.WriteLine(string.Format("{0:00.0000}", time) + " seconds");
            Console.WriteLine();
            if (gap < 1000)
            {
                Console.WriteLine($"Ooh! So close! You were under 1 second out.");
            }
            else if (gap < 3000)
            {
                Console.WriteLine($"A way out, but not too bad.");
            }
            else if (gap >= 3000)
            {
                Console.WriteLine($"Way off! Try Again.");
            }
        }

        private static void WriteLine(string text, int sleepInMilliseconds = 0)
        {
            Thread.Sleep(sleepInMilliseconds);
            Console.WriteLine(text);
        }
    }
}
