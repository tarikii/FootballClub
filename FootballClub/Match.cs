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
        Random random = new Random();

        public int[] Goals { get => goals; set => goals = value; }
        public string Score { get => score; set => score = value; }
        public Team[] MatchMaking { get => matchMaking; set => 
                matchMaking = value; }

        public Match(Team team1, Team team2)
        {
            goals = new int[] {0, 0};
            score = goals[0] + " - " + goals[1];
            matchMaking = new Team[] { team1, team2};
        }

        public void ScoreGoal()
        {
            int randomNumber = random.Next(0, 1);

            if (randomNumber == 0)
                Goals[0]++;
            else if (randomNumber == 1)
                Goals[1]++;

            Score = Goals[0] + " - " + Goals[1];
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
