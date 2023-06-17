using System.Collections.Generic;

namespace Heist
{

    // Create a way to store several team members.
    public class Team
    {

        // dictionary key = individual's name, value = TeamMember class
        public Dictionary<string, TeamMember> HeistTeam = new Dictionary<string, TeamMember>() { };

        public void AddToTeam(TeamMember individual)
        {
            HeistTeam.Add(individual.Name, individual);
        }

    }



}