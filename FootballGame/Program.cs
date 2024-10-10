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
                Console.WriteLine("Generating Players For Both Teams...\n");
                GeneratePlayers(team1, team1Name);
                GeneratePlayers(team2, team2Name);

                // Display teams
                DisplayTeam(team1);
                DisplayTeam(team2);

                // Start match
                Match match = new Match(team1, team2);
                match.PlayMatch();
            }


            private static void GeneratePlayers(Team team, string teamName)// generate 11 players for a team
            {
                Random random = new Random();


                string[] RealMadridTeam = { "Thibaut Courtois", "Dani Carvajal", "Eder Militão", "David Alaba", "Ferland Mendy",
                                      "Casemiro", "Luka Modrić", "Toni Kroos", "Vinícius Júnior", "Karim Benzema",// Player names for Real Madrid
                                      "Rodrygo" };


                string[] BarcelonaTeam = { "Marc-André ter Stegen", "Sergi Roberto", "Gerard Piqué", "Jordi Alba",
                                     "Eric García", "Sergio Busquets", "Frenkie de Jong", "Gavi",
                                     "Ansu Fati", "Robert Lewandowski", "Ousmane Dembélé" };// Player names for Barcelona

                string[] names = teamName switch
                {
                    "Real Madrid" => RealMadridTeam,
                    "Barcelona" => BarcelonaTeam,
                    _ => RealMadridTeam // Default to Real Madrid names for any other team
                };

                Position[] positions = { Position.Forward, Position.Midfielder, Position.Defender, Position.Goalkeeper };
                for (int i = 0; i < 11; i++)
                {
                    string name = names[random.Next(names.Length)];
                    Position position = positions[i % positions.Length]; // Distribute positions evenly
                    int skill = random.Next(80, 101); // Skill level between 80 and 100
                    team.Players.Add(new Player(name, position, skill));
                }
            }







        }
    }
    
}
