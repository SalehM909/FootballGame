namespace FootballGame
{
    public class Program
    {
        public class GameSimulator
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Soccer Game Simulator!");

                // Input team names
                Console.Write("Enter Name For First Team : ");
                string team1Name = Console.ReadLine();
                Console.Write("Enter Name For Second Team : ");
                string team2Name = Console.ReadLine();

                // Create teams
                Team team1 = new Team(team1Name);
                Team team2 = new Team(team2Name);

                // Generate players
                Console.WriteLine("Generating Players For Both Teams...");
                GeneratePlayers(team1, team1Name);
                GeneratePlayers(team2, team2Name);

                // Display teams
                DisplayTeam(team1);
                DisplayTeam(team2);

                // Start match
                Match match = new Match(team1, team2);
                match.PlayMatch();
            }

        }





    }
    
}
