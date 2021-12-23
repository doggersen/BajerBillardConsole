using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajerBillardConsoleTest01
{
    internal class Game
    {

        List<Player> players = new List<Player>();

        Player player = new Player();

        public Game()
        {
            Console.Write("skriv navn på første spiller: ");
        }

        public void AddPlayers(string name)
        {
         
                players.Add(new Player(name));
                //Console.WriteLine("Tilføj flere spillere? skriv '1' for ja, '2' for nej.");
                //string userInput = Console.ReadLine();
                //if (userInput == "1")
                //{
                //    Console.Write($"skriv næste spiller: ");
                //    AddPlayers(Console.ReadLine());
                //}

        }
 
        public void ShowPlayerList()
        {
            Console.WriteLine("Status:");
            foreach (Player p in players)
            {
                Console.WriteLine($"Navn: {p.Name}, Score: {p.Point} point, ID: {p.Id}");
            }

        }

        public void GodeEllerSkaeve()
        {
            //Player p;

            while (player.Point > 0)
            {
                foreach (Player p in players.ToList()) //If you add ".ToList()" to your list (or the results of a LINQ query), you can remove "item" directly from "list" without the dreaded "Collection was modified; enumeration operation may not execute." error.
                {
                 
                    void DuHarVundet(string name)
                    {
                        Console.WriteLine($"{p.Name} du har vundet! De andre spiller videre uden dig.");

                        var player = players.FirstOrDefault(x => x.Name == p.Name);

                        players.Remove(player);
                    }

                    Console.WriteLine($"{p.Name}, det er din tur.");
                    Console.WriteLine("skriv '1' for Gode eller '2' for Skæve");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("Skriv hvor mange point du fik");
                    int recievedPoints = Convert.ToInt32(Console.ReadLine());
                    //Gode:
                    if (userInput == "1")
                    {
                        p.Point = p.Point - recievedPoints;
                        if (p.Point <= 0) DuHarVundet(p.Name);
                    }
                    //Skæve:
                    if (userInput == "2")
                    {
                        p.Point = p.Point + recievedPoints;

                        foreach (Player p2 in players.ToList()) //If you add ".ToList()" to your list (or the results of a LINQ query), you can remove "item" directly from "list" without the dreaded "Collection was modified; enumeration operation may not execute." error.
                        {
                            p2.Point = p2.Point - recievedPoints;
                            if (p2.Point <= 0) DuHarVundet(p2.Name);
                        }
                    }
                    ShowPlayerList();
                }

            }
        }
    }
}
