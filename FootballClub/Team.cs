using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    public class Team
    {
        string teamName;

        public string TeamName { get; }
        public List<Player> Players { get; }

        public Team(string teamName)
        {
            this.teamName = teamName;
            Players = new List<Player>();
        }
    }
}
