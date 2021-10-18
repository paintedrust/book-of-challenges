using System;
using System.Collections.Generic;
using System.Linq;

namespace BookOfChallenges
{
    public static class Constants
    {
        private static IEnumerable<ConsoleColor> FontColours() {
            var colours = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            // Remove invisible and default colours
            return colours.Where(clr => 
                clr != ConsoleColor.Black &&
                clr != ConsoleColor.White
            );
        }

        public static ConsoleColor GetRandomColour()
        {
            var random = new Random();
            return FontColours().ElementAt(random.Next(FontColours().Count()));
        }
    }
}
