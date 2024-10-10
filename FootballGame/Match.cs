using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Match
    {
        private Team Team1;
        private Team Team2;
        private int Score1;
        private int Score2;
        private Random random = new Random();

        public Match( Team team1, Team team2) 
        {
            Team1 = team1;
            Team2 = team2;
            Score1 = 0;
            Score2 = 0;
        }
        // constructors 

        //
        // Simulate coin toss
        private Team CoinToss()//select one of the two teams
        {
            return random.Next(0, 2) == 0 ? Team1 : Team2;//( between 0 and 2)it can return either 0 or 1 //  If its 0, it returns Team1; otherwise, it returns Team2
        }

    }
}
