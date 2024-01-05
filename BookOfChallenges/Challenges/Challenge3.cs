using System;
namespace BookOfChallenges.Classes
{
    public static class Challenge3
    {
        public static void Run()
        {
            Console.WriteLine("Enter values to calculate the size of a rectangle ");
            Console.WriteLine("\nWidth: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.WriteLine("\nHeight: ");
            Double.TryParse(Console.ReadLine(), out double height);
            Console.WriteLine("\nLength (optional): ");
            Double.TryParse(Console.ReadLine(), out double length);

            width = Math.Abs(width);
            height = Math.Abs(height);
            length = Math.Abs(length);

            var area = width * height;
            Console.WriteLine("\nArea of a Rectangle: " + area);

            if (length > 0)
            {
                var volume = area * length; // w * h * l
                var surfaceArea = 2 * (length * height + length * width + width * height); //2 (lb + bh + lh)
                Console.WriteLine("Volume of a Cuboid: " + volume);
                Console.WriteLine("Surface Area of a Cuboid: " + surfaceArea);
            }
        }
    }
}
