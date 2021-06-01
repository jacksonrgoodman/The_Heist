using System;
using System.Collections.Generic;
namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store a value for the bank's difficulty level. Set this value to 100.
            //? At the beginning of the program, prompt the user to enter the difficulty level of the bank.
            Console.Write("Pick a number between 0 and one hundred (bank difficulty)? ");
            int difficultyLevel = 0;
            bool difficulty = int.TryParse(Console.ReadLine(), out difficultyLevel);
            try
            {

                while (!difficulty || difficultyLevel < 0 || difficultyLevel > 100)
                {
                    if (!difficulty)
                    {
                        Console.Write("Can you please enter a number? ");
                    }
                    else if (difficultyLevel < 0 || difficultyLevel > 100)
                    {
                        Console.Write("Please enter a number between 0 and one hundred: ");
                    }
                    difficulty = int.TryParse(Console.ReadLine(), out difficultyLevel);
                }

            }
            catch
            {
                Console.WriteLine("you broke it");
            }
            // Create a random number between -10 and 10 for the heist's luck value.
            int luckValue = new Random().Next(-10, 10);

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
            int trials;
            //? After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
            Console.Write("How many trials do you want to run? ");

            bool newTrials = int.TryParse(Console.ReadLine(), out trials);
            while (!newTrials || trials < 1)
            {
                if (!newTrials)
                {
                    Console.Write("Can you please enter a number");
                }
                else if (trials < 0)
                {
                    Console.Write("Please enter a number greater than 0: ");
                }
                newTrials = int.TryParse(Console.ReadLine(), out trials);
            }

            //* Run the scenario multiple times.
            //? Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
            int successes = 0;

            for (int i = 0; i < trials; i++)
            {

                // Create a random number between -10 and 10 for the heist's luck value.
                luckValue = new Random().Next(-10, 10);


                // Add this number to the bank's difficulty level.
                int totalDifficulty = difficultyLevel + luckValue;
                Console.WriteLine("Bank Difficulty:" + " " + totalDifficulty);
                //             Before displaying the success or failure message, display a report that shows.
                // The team's combined skill level
                // The bank's difficulty level
                Console.WriteLine("Team Level:" + " " + Squad.TeamLevel);
                // Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
                if ((totalDifficulty) <= Squad.TeamLevel)
                {
                    successes++;
                    Console.WriteLine("Heist is a success!");
                }
                else
                {
                    Console.WriteLine("Heist failed! Send 'em to Gitmo.");

                }
            }
            //? At the end of the program, display a report showing the number of successful runs and the number of failed runs.
            Console.WriteLine("Number of Successes: " + successes);
            Console.WriteLine("Number of Failures: " + (trials - successes));



        }
    }
}



