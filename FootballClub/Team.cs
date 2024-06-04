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

        public string TeamName { get; set; }
        public List<Player> Players { get; set; }

        public Team(string teamName)
        {
            this.teamName = teamName;
            Players = new List<Player>();
        }

        public Team() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name of the Team: {TeamName}");
            sb.AppendLine("Players:");
            foreach (var player in Players)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }
    }
}
