using System;
using System.Collections.Generic;
using System.Linq;
namespace BajerBillardConsoleTest01
{
    internal class Game
    {
        int PladsCounter = 1;
        List<Player> listPlayers = new List<Player>();
        List<Player> listPlayersGameOver = new List<Player>();
        List<Player> listPlayersHistory = new List<Player>();

        public Game()
        {
            Console.Write("skriv navn på første spiller: ");
        }
        public void AddPlayers(string name)
        {
            listPlayers.Add(new Player(name));
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
            Console.WriteLine($"Status: ");
            foreach (Player p in listPlayers)
            {
                Console.WriteLine($"Navn: {p.Name}, Score: {p.Point} point");
            }
        }
        void Winner(string name)
        {
            Console.WriteLine($"{name}, du kom på {PladsCounter}.pladsen!");
            var player = listPlayers.FirstOrDefault(x => x.Name == name);
            player.Plads = PladsCounter;
            PladsCounter++;
            listPlayersGameOver.Add(player); //add player to gameover list before being removed!
            listPlayers.Remove(player);
            if (listPlayers.Count == 0)
            {
                GameOver();
            }
        }
        //når der kun er en spiller tilbage
        void GameOver()
        {
            Console.WriteLine("Samlet status: ");
            foreach (Player p in listPlayersGameOver)
            {
                Console.WriteLine($"{p.Plads}.pladsen: {p.Name} Skæve i alt: {p.SkaeveAccumulated}");
            }
            
            Console.WriteLine("Hvis der skulle startes et nyt spil, ville rækkefølgen være således: ");
            listPlayersGameOver.Sort((x, y) => y.Plads.CompareTo(x.Plads)); //hvis der byttes rundt på x og y til højre i ligningen, sorteres der "ascending" i stedet for "descending". 
            foreach (Player p in listPlayersGameOver)
            {
                Console.WriteLine($"{p.Name}");
            }
            Console.ReadKey();
            
        }
        public void GodeEllerSkaeve()
        {
           while (listPlayers.Count > 0) //seems to be of no importance, since the below if-statement ends the loop anyway, by calling the GameOver() method
            { 
                foreach (Player p in listPlayers.ToList()) //If you add ".ToList()" to your list (or the results of a LINQ query), you can remove "item" directly from "list" without the dreaded "Collection was modified; enumeration operation may not execute." error.
                {
                    if (listPlayers.Count == 1) //en spiller tilbage, spillet slutter. 
                    {
                        Winner(p.Name);
                    }
                    Console.WriteLine($"{p.Name}, det er din tur.");
                    Console.Write("skriv '1' for Gode eller '2' for Skæve: ... ");
                    string userInput = Console.ReadLine();
                    Console.Write("Skriv hvor mange point du fik: ... ");
                    int recievedPoints = Convert.ToInt32(Console.ReadLine());
                    //Gode:
                    if (userInput == "1")
                    {
                        p.Point = p.Point - recievedPoints;
                        if (p.Point <= 0) Winner(p.Name);
                    }
                    //Skæve:
                    if (userInput == "2")
                    {
                        p.Point = p.Point + recievedPoints;
                        p.SkaeveAccumulated += recievedPoints;
                        foreach (Player p2 in listPlayers.ToList()) //If you add ".ToList()" to your list (or the results of a LINQ query), you can remove "item" directly from "list" without the dreaded "Collection was modified; enumeration operation may not execute." error.
                        {
                            p2.Point = p2.Point - recievedPoints;
                            if (p2.Point <= 0) Winner(p2.Name);
                        }
                    }
                    ShowPlayerList();
                }
             }
        }
    }
}
