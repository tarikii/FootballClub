using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    public class Match
    {
        int[] goals;
        string score;
        Team[] matchMaking;

        public int[] Goals { get => goals; set => goals = value; }
        public string Score { get => score; }
        public Team[] MatchMaking { get => matchMaking; set => 
                matchMaking = value; }

        public Match(Team team1, Team team2)
        {
            goals = new int[] {0, 0};
            score = goals[0] + " - " + goals[1];
            matchMaking = new Team[] { team1, team2};
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Team Match: {MatchMaking[0].TeamName} vs " +
                $"{MatchMaking[1].TeamName}");
            sb.AppendLine($"Result: {Score}");
            return sb.ToString();
        }
    }
}
