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

        // Play a turn
        private void PlayTurn(Team attackingTeam, Team defendingTeam)
        {
            int attackSkill = attackingTeam.CalculateAttackSkill();
            int defenseSkill = defendingTeam.CalculateDefenseSkill();

            if (attackSkill > defenseSkill)
            {
                Console.WriteLine($"{attackingTeam.Name} are attacking now......>>>>>> Goal!\n");
                if (attackingTeam == Team1) Score1++;
                else Score2++;
            }
            else
            {
                Console.WriteLine($"{attackingTeam.Name} are attacking now......>>>>>> Defended successfully!\n");
            }

            
            Console.WriteLine($"Current Score: {Team1.Name}: {Score1} | {Team2.Name}: {Score2}");// Display current score after each turn
        }


    }
}
