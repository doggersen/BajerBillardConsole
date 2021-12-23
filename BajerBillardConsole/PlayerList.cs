namespace BajerBillardConsole
{
    public class PlayerList
    {
        public List<Player>? Players { get; set; }


        public void AddPlayer()
        {
            Players.Add(new Player("Jimmy"));

        }

        public void ShowList()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
