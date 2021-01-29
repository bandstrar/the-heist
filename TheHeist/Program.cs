using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            int teamSkill = 0;
            int bankDifficulty = 100;
            var teamMembers = new List<TeamMember>
            { };
            while (true)
            {
                Console.WriteLine("Enter your team member's name. Leave blank and press enter when your team is finished.");
                var name = Console.ReadLine();
                if (name != "")
                {
                    Console.WriteLine("Enter that team member's skill level. Pick a number between 1-50.");
                    var skillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter that team member's courage factor. Enter a decimal number between 0.0 and 2.0.");
                    var courageFactor = double.Parse(Console.ReadLine());

                    var teamMember = new TeamMember(name, skillLevel, courageFactor);
                    teamMembers.Add(teamMember);

                    continue;
                }
                else
                {
                    break;
                }
                
            }
            
                       
            Console.WriteLine($"There are {teamMembers.Count} members on your team.");
            foreach (var member in teamMembers)
            {
                teamSkill += member.SkillLevel;
            }

            if (teamSkill >= bankDifficulty)
            {
                Console.WriteLine("The heist was a success! Enjoy your newfound wealth!");
            }
            else
            {
                Console.WriteLine("The heist was a failure! No movies starring George Clooney and Brad Pitt will be based on you.");
            }
                  
        }
    }
}
