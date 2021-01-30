using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist! Please enter your difficulty level.");
            var difficultyLevel = int.Parse(Console.ReadLine());

            var newBank = new Bank(difficultyLevel);
            int teamSkill = 0;
            var teamMembers = new List<TeamMember> { };
            int successCount = 0;
            int failureCount = 0;
            
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

            Console.WriteLine("Please enter how many trial runs you would like to perform.");
            var trialRuns = int.Parse(Console.ReadLine());
            
            foreach (var member in teamMembers)
            {
                teamSkill += member.SkillLevel;
            }

            for (var i = 0; i < trialRuns; i++)
            {
                newBank.AssignLuck();
                
                int bankDifficulty = newBank.Difficulty + newBank.LuckValue;

                Console.WriteLine($"Your team's skill level is {teamSkill}. The bank's difficulty level is {bankDifficulty}");

                if (teamSkill >= bankDifficulty)
                {
                    Console.WriteLine("The heist was a success! Enjoy your newfound wealth!");
                    successCount++;
                }
                else
                {
                    Console.WriteLine("The heist was a failure! No movies starring George Clooney and Brad Pitt will be based on you.");
                    failureCount++;
                }

            }
            Console.WriteLine($"You had a total of {successCount} successful runs and {failureCount} failed runs.");
                  
        }
    }
}
