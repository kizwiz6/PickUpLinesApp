internal class Program
{
    private static void Main(string[] args)
    {
        string[] pickupLines =
        {
            "Are you a magician? Because whenever I look at you, everyone else disappears.",
            "Do you have a map? Because I just got lost in your eyes.",
            "I must be a snowflake, because I've fallen for you.",
            "Do you have a sunburn, or are you always this hot?",
            "If you were a vegetable, you'd be a cutecumber."
        };

        introductionText();
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();

        Random random = new Random();
        int lineIndex = random.Next(pickupLines.Length);

        Console.WriteLine(pickupLines[lineIndex]);
        Console.ReadLine();
    }

    static void introductionText()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Welcome to the Pick-Up Line Generator!");
        Console.WriteLine("Press Enter to generate a line...");
    }
}