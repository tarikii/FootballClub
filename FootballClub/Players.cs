using System;
namespace FootballClub
{
	public class Player
	{
		int id;
		string name;
		string lastName;
		string team;
		int number;
		string notes;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Team { get => team; set => team = value; }
        public int Number { get => number; set => number = value; }
        public string Notes { get => notes; set => notes = value; }

        public Player()
        {
        }

        public Player(int id, string name, string lastName, string team, int number, string notes)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.team = team;
            this.number = number;
            this.notes = notes;
        }
    }
}

