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
        // Play the match
        public void PlayMatch()
        {
            Console.WriteLine("--- First Half ---\n");
            Team firstAttackingTeam = CoinToss();
            Team secondAttackingTeam = firstAttackingTeam == Team1 ? Team2 : Team1;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Turn {i}: {firstAttackingTeam.Name} are attacking......>>>>>>\n");
                PlayTurn(firstAttackingTeam, secondAttackingTeam);
                // Switch teams for next turn
                var temp = firstAttackingTeam;
                firstAttackingTeam = secondAttackingTeam;
                secondAttackingTeam = temp;
            }

            Console.WriteLine("--- Second Half ---\n");
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine($"Turn {i}: {firstAttackingTeam.Name} are attacking......>>>>>>\n");
                PlayTurn(firstAttackingTeam, secondAttackingTeam);
                var temp = firstAttackingTeam;
                firstAttackingTeam = secondAttackingTeam;
                secondAttackingTeam = temp;
            }

            DisplayFinalScore();
        }
        private void DisplayFinalScore()
        {
            Console.WriteLine("\nFinal Score:");
            Console.WriteLine($"{Team1.Name}: {Score1} | {Team2.Name}: {Score2}");
            if (Score1 > Score2)
                Console.WriteLine($"{Team1.Name} >>>IS THE WINNER***^-^\n");
            else if (Score1 < Score2)
                Console.WriteLine($"{Team2.Name} >>>IS THE WINNER***^-^\n");
            else
                Console.WriteLine("It's a ^draw^\n");
            Console.ReadKey();
        }



    }
}
