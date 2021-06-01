using System;
using System.Collections.Generic;
namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            // Prompt the user to enter a team member's name and save that name.
            Console.Write("Enter a team member's name: ");
            string Name = Console.ReadLine();

            // Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.Write("Enter a team member's skill level: ");
            string Answer = Console.ReadLine();
            int SkillLevel;
            bool isNum = int.TryParse(Answer, out SkillLevel);

            while (!isNum)
            {
                Console.WriteLine("Can you please enter a number");
                Answer = Console.ReadLine();
                isNum = int.TryParse(Answer, out SkillLevel);
            }

            // Prompt the user to enter a team member's courage factor and save that courage factor with the name.

        }
    }
}
