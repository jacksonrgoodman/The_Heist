using System;
using System.Collections.Generic;

namespace heist
{
    class Squad
    {
        //? Create A Way To Store Multiple Team Members
        List<TeamMember> Team = new List<TeamMember>();

        //* Adds the Guy
        public void AddTeamMember(TeamMember Newguy)
        {
            Team.Add(Newguy);
        }
        public void DisplayTeam()
        {
            //? Display a message containing the number of members of the team.
            Console.WriteLine($"Member Count: {Team.Count}");
            int i = 1;
            foreach (TeamMember member in Team)
            //? Display each team member's information.
            {
                Console.WriteLine($"{i++}. {member.Name}, {member.SkillLevel}, {member.CourageFactor}");
            }

        }
    }

}