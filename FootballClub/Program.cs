using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            Club club = new Club();
            Match match;
            int? option = 0;

            while (true)
            {
                option = main.ShowMenu();

                if (option == 1)
                    club.RegisterTeam();
                else if (option == 2)
                    Console.WriteLine(club);
                else if (option == 3)
                {
                    match = club.CreateMatch();
                    match.ScoreGoal();
                    Console.WriteLine(match);
                }
                else
                    return;
            }
        }

        public int? ShowMenu()
        {
            int option = 0;
            bool parseOk = false;

            Console.WriteLine("WELCOME TO REGISTER TEAM FOUNDATION!");
            Console.WriteLine("\n1. Register a team");
            Console.WriteLine("2. List team");
            Console.WriteLine("0. Exit");
            Console.Write("Pick an option: ");

            parseOk = Int32.TryParse(Console.ReadLine(), out option);

            if (parseOk)
                return option;
            else
                Console.WriteLine("This number is not valid!");
            return null;
        }

    }
}
