using System;

namespace SocialNetwork.PLL.Helpers
{
    public class SuccessMessage
    {
        public static void Show(string message)
        {
            ConsoleColor originalColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{ message}");
            Console.ForegroundColor = originalColour;
        }
    }
}
