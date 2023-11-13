namespace Agustina_Checkpoint2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("Jessheim Idrettsklubb");
            team.Players= new List<Player>()
            {
                new Player("Agustina", 2),
                new Player("Agustin", 3),
                new Player("Alejandro", 4),
                new Player("Juan Pablo", 5),
                new Star("Iman", 10, "very active"),
            };

            team.PrintTeam(team.Players);

        }
    }
}