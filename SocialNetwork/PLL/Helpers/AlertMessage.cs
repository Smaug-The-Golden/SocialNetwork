using System;

namespace SocialNetwork.PLL.Helpers
{
    public class AlertMessage
    {
        public static void Show (string message)
        {
            ConsoleColor originalColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n{ message}");
            Console.ForegroundColor = originalColour;
        }
    }
}
