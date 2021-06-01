using System;

namespace heist
{
    class TeamMember
    {
        //    Create a way to store a single team member.
        //    A team member will have a name, a skill Level 
        //    and a courage factor. The skill Level will be 
        //    a positive integer and the courage factor will 
        //    be a decimal between 0.0 and 2.0.

        public string Name { get; }
        public int SkillLevel { get; }

        public double CourageFactor { get; }

        public TeamMember(string Name, int SkillLevel, double CourageFactor)
        {

            this.Name = Name;
            this.SkillLevel = SkillLevel;
            this.CourageFactor = CourageFactor;

        }

    }
}
