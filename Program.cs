using PickUpLinesApp;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Welcome to the Pick-Up Line Generator!");
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        User user = new User(name);
        PickUpLineGenerator generator = new PickUpLineGenerator();
        string pickUpLine = generator.GetPickUpLine(user);

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine(" ___________");
            Console.WriteLine("< Let's go! >");
            Console.WriteLine(" -----------");
            Console.WriteLine("        \\   ^__^");
            Console.WriteLine("         \\  (oo)\\_______");
            Console.WriteLine("            (__)\\       )\\/\\");
            Console.WriteLine("                ||----w |");
            Console.WriteLine("                ||     ||");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to generate a line or type 'exit' to quit...");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Here's your pick-up line:");
            Console.WriteLine(pickUpLine);
            Console.ReadLine();
        }
    }
}