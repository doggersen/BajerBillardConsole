using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajerBillardConsoleTest01
{
    internal class Player
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public Player(string name = "Anonymous", int point = 60)
        {
            Name = name;
            Point = point;
        }


        List<Player> players = new List<Player>();

        public void AddPlayers()
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
        public void ShowPlayerList()
        {
            Console.WriteLine("Status:");
            foreach (Player p in players)
            {
                Console.WriteLine($"Navn: {p.Name}, Score: {p.Point} point");
            }

        }

        public void GodeEllerSkaeve()
        {
            //Player p;

            while (Point > 0)
            {
                foreach (Player p in players)
                {
                    Console.WriteLine($"{p.Name} det er din tur.");
                    Console.WriteLine("skriv '1' for Gode eller '2' for Skæve");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("Skriv hvor mange point du fik");
                    int recievedPoints = Convert.ToInt32(Console.ReadLine());
                    //Gode:
                    if (userInput == "1")
                    {
                        p.Point = p.Point - recievedPoints;
                    }
                    //Skæve:
                    if (userInput == "2")
                    {
                        p.Point = p.Point + recievedPoints;

                        foreach (Player p2 in players)
                        {
                            p2.Point = p2.Point - recievedPoints;
                        }
                    }
                    ShowPlayerList();
                }

            }
        }


    }
}
