using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    public class Club
    {
        
        public List<Team> Teams { get; }

        public Club()
        {
            Teams = new List<Team>();
        }

        public void RegisterTeam()
        {
            string teamName;
            Team team = new Team();
            List<Player> players = new List<Player>();
            int numPlayers = 0;

            // Create 3 players
            while (numPlayers != 3)
            {
                players.Add(RegisterPlayer());
                numPlayers++;
            }

            Console.Write("What would be the name of the team: ");

            teamName = Console.ReadLine();
            team.TeamName = teamName;
            team.Players = players;

            Teams.Add(team);
        }

        public Player RegisterPlayer()
        {
            string name;
            string lastName;
            int number;
            Player player = new Player();

            bool parseOk = false;

            Console.Write("Name of the player: ");
            name = Console.ReadLine();

            Console.Write("Last name of the player: ");
            lastName = Console.ReadLine();

            Console.Write("Number of the player: ");
            parseOk = Int32.TryParse(Console.ReadLine(), out number);

            if (parseOk)
            {
                player.Name = name;
                player.LastName = lastName;
                player.Number = number;
            }
            else
                Console.WriteLine("Couldn't register the player, something went wrong!");

            return player;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Team team in Teams)
                sb.AppendLine(team.ToString());

            return sb.ToString();

        }
    }
}
