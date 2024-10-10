using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public enum Position // using this options only
    {
        Forward,
        Midfielder,
        Defender,
        Goalkeeper
    }

    // Player class
    public class Player
    {
        public string Name { get; set; }
        public Position Position { get; set; } // using what I write in position
        public int SkillsLevel { get; set; }

        public Player(string name, Position position, int skillsLevel)// constructor method that takes three parameters
        {
            Name = name;
            Position = position;
            SkillsLevel = skillsLevel;
        }
    }
}
