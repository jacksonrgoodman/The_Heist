﻿using System;
using System.Collections.Generic;
namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            // Prompt the user to enter a team member's name and save that name.
            Squad Squad = new Squad();
            string Name = "0";
            while (Name != "")
            {

                Console.Write("Enter a team member's name: ");
                Name = Console.ReadLine();

                // Prompt the user to enter a team member's skill level and save that skill level with the name.
                //? Stop Collecting Team Members when empty string is entered
                if (Name != "")
                {

                    Console.Write("Enter a team member's skill level: ");
                    string Answer = Console.ReadLine();
                    int SkillLevel;
                    bool isNum = int.TryParse(Answer, out SkillLevel);
                    try
                    {

                        while (!isNum || SkillLevel < 0)
                        {
                            if (!isNum)
                            {
                                Console.Write("Can you please enter a number");
                            }
                            else if (SkillLevel < 0)
                            {
                                Console.Write("Please enter a number greater than 0: ");
                            }
                            Answer = Console.ReadLine();
                            isNum = int.TryParse(Answer, out SkillLevel);
                        }

                    }
                    catch
                    {
                        Console.WriteLine("you broke it");
                    }
                    // Validation of user input
                    // And store variables
                    // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                    Console.Write("Enter a team member's courage factor from 0.0 to 2.0: ");
                    string courageAnswer = Console.ReadLine();
                    double courageFactor;
                    isNum = double.TryParse(courageAnswer, out courageFactor);
                    try
                    {

                        while (!isNum || courageFactor < 0.0 || courageFactor > 2.0)
                        {
                            if (!isNum)
                            {
                                Console.Write("Can you please enter a number");
                            }
                            else if (courageFactor < 0.0 || courageFactor > 2.0)
                            {
                                Console.Write("Please enter a value between 0.0 and 2.0: ");
                            }
                            courageAnswer = Console.ReadLine();
                            isNum = double.TryParse(courageAnswer, out courageFactor);
                        }

                    }
                    catch
                    {
                        Console.WriteLine("you broke it");
                    }
                    if (Name != "")
                    {
                        //? Collect Several Team Members' information

                        TeamMember Newguy = new TeamMember(Name, SkillLevel, courageFactor);
                        Squad.AddTeamMember(Newguy);
                    }
                }
            }
            //? display team member information
            Squad.DisplayTeam();


        }
    }
}



