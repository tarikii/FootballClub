using System;
namespace FootballClub
{
    public class Player
    {
        string name;
        string lastName;
        int number;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Number { get => number; set => number = value; }

        public Player()
        {
        }

        public Player(string name, string lastName, int number)
        {
            this.name = name;
            this.lastName = lastName;
            this.number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Last Name: {LastName}; " +
                $"Number of the player: {Number}";
        }
    }
}

