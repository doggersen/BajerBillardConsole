using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajerBillardConsoleTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            addPlayers(players);

            foreach (Player p in players)
            {
                Console.WriteLine($"Navn: {p.Name}, Score: {p.Point} point");
            }


            Console.ReadKey();
        }

        private static void addPlayers(List<Player> players)
        {
            bool morePlayers = true;
            while (morePlayers)
            {
                Console.WriteLine("skriv navn på spiller");
                players.Add(new Player(Console.ReadLine()));
                Console.WriteLine("Tilføj flere spillere? skriv '1' for ja, '2' for nej.");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    morePlayers = true;
                }
                else break;

            }
        }
    }
}
