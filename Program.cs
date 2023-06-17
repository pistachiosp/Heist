using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            NewTeamMember();

            static void NewTeamMember()
            {
                System.Console.WriteLine();
                // Print the message "Plan Your Heist!".
                Console.WriteLine("Plan your Heist");


                Bank theBank = new Bank();
                // At the beginning of the program, prompt the user to enter the difficulty level of the bank.
                System.Console.WriteLine();
                System.Console.WriteLine($"How challenging do you want your bank to be?");
                string bankDifficultyString = Console.ReadLine();
                int BankDifficulty = int.Parse(bankDifficultyString);
                theBank.BankDifficultyLevel = BankDifficulty;

                System.Console.WriteLine("Time to add your Team Members!");
                Team heistTeam = new Team();

                // Add a team member
                void NewTeamMember()
                {
                    // Prompt the user to enter a team member's name and save that name.
                    Console.WriteLine("What is your team member's name?");
                    string TeamMemberName = Console.ReadLine();
                    // Stop collecting team members when a blank name is entered.
                    if (TeamMemberName == "")
                    {
                        return;
                    }
                    // Prompt the user to enter a team member's skill level and save that skill level with the name.
                    Console.WriteLine("What is your team member's skill level on a scale of 1 to 100 (whole numbers only)?");
                    string skillLevelString = Console.ReadLine();
                    int skillLevel = Convert.ToInt32(skillLevelString);
                    // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                    Console.WriteLine("What is your team member's courage level on a scale of 0.0 to 2.0?");
                    string courageLevelString = (Console.ReadLine());
                    decimal courageLevel = Convert.ToDecimal(courageLevelString);

                    TeamMember theTeamMember = new TeamMember(TeamMemberName, skillLevel, courageLevel);
                    // Display the team member's information.
                    // Stop displaying each team member's information.
                    // theTeamMember.GetDescription();

                    // Collect several team members' information.
                    heistTeam.AddToTeam(theTeamMember);
                    addAnotherTeamMember();

                }
                NewTeamMember();

                // Display a message containing the number of members of the team.
                Console.WriteLine($"You have added {heistTeam.HeistTeam.Count} team members to the Heist.");

                // Display each team member's information.
                // Stop displaying each team member's information.
                // foreach (TeamMember individual in heistTeam.HeistTeam.Values)
                // {
                //     individual.GetDescription();
                // };

                // Sum the skill levels of the team. Save that number.
                int TotalSkillLevel = 0;
                foreach (TeamMember individual in heistTeam.HeistTeam.Values)
                {
                    TotalSkillLevel += individual.SkillLevel;
                };
                void addAnotherTeamMember()
                {
                    NewTeamMember();

                }

                // After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
                System.Console.WriteLine("How many trial runs would you like to perform?");
                string trialRunsString = Console.ReadLine();
                int trialRuns = int.Parse(trialRunsString);

                // Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
                for (int i = 1; i <= trialRuns; i++)
                {
                    void runHeist()
                    {
                        // Create a random number between -10 and 10 for the heist's luck value.
                        Random random = new Random();
                        int luckValue = random.Next(-10, 11);
                        // Add this luckValue number to the bank's difficulty level.
                        int adjustedBankDifficultyLevel = theBank.BankDifficultyLevel + luckValue;

                        // Before displaying the success or failure message, display a report that shows.
                        //The team's combined skill level
                        // The bank's difficulty level
                        System.Console.WriteLine($"Your team's total skill level is {TotalSkillLevel}.");
                        System.Console.WriteLine($"The bank's difficulty level is {adjustedBankDifficultyLevel}");

                        // Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.  
                        if (adjustedBankDifficultyLevel > TotalSkillLevel)
                        {
                            System.Console.WriteLine("Your heist failed - Go straight to jail!");
                            theBank.failedRuns += 1;
                        }
                        else
                        {
                            System.Console.WriteLine("Your heist was successful - Collect your REWARD!");
                            theBank.successfulRuns += 1;
                        }

                        // At the end of the program, display a report showing the number of successful runs and the number of failed runs.
                        System.Console.WriteLine();
                        System.Console.WriteLine($"You robbed the bank successfully {theBank.successfulRuns} times and failed {theBank.failedRuns} times.");


                    }

                    runHeist();
                }





            }


        }
    }
}
