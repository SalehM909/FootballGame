using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        // Properties
        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();// Constructor + list of player names 
        }

        // Calculate total attacking skill (Forwards and Midfielders)
        public int CalculateAttackSkill()
        {
            return Players.Where(p => p.Position == Position.Forward || p.Position == Position.Midfielder)
                          .Sum(p => p.SkillsLevel);
        }

        // Calculate total defending skill (Defenders and Goalkeeper)
        public int CalculateDefenseSkill()
        {
            return Players.Where(p => p.Position == Position.Defender || p.Position == Position.Goalkeeper)
                          .Sum(p => p.SkillsLevel);
        }
    }
}
