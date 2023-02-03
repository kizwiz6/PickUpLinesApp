using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickUpLinesApp
{
    public class PickUpLineGenerator
    {
        private string[] pickUpLines = {
            "Are you a magician, [Name]? Because whenever I look at you, everyone else disappears.",
            "Do you have a map, [Name]? Because I just got lost in your eyes.",
            "I must be a snowflake, [Name], because I've fallen for you.",
            "Do you have a sunburn, [Name], or are you always this hot?",
            "If you were a vegetable, [Name], you'd be a cutecumber.",
            "Is your name Google, [Name]? Because you have everything I've been searching for.",
            "I must be lost, [Name], because heaven is a long way from here.",
            "Excuse me, [Name], but I think you dropped something... my jaw.",
            "I'm not a photographer, [Name], but I can definitely picture us together.",
            "You must be a magician, [Name], because every time I look at you, everyone else disappears."
        };

        private Random random = new Random();

        public string GetPickUpLine(User user)
        {
            int lineIndex = random.Next(pickUpLines.Length);
            string pickUpLine = pickUpLines[lineIndex].Replace("[Name]", user.Name);
            return pickUpLine;
        }
    }
}
