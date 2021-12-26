using System;
using System.Collections.Generic;
using System.Linq;

namespace BajerBillardConsoleTest01
{
    internal class Game
    {

        List<Player> listPlayers = new List<Player>();

        List<Player> listPlayersGameOver = new List<Player>();

        List<Player> listPlayersHistory = new List<Player>();

        //Player player = new Player();

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
            Console.WriteLine("Status:");
            foreach (Player p in listPlayers)
            {
                Console.WriteLine($"Navn: {p.Name}, Score: {p.Point} point, ID: {p.Id}");
            }

        }
        void Winner(string name)
        {
            Console.WriteLine($"{name} du har vundet! De andre spiller videre uden dig.");

            var player = listPlayers.FirstOrDefault(x => x.Name == name);

            listPlayersGameOver.Add(player); //add to the gameover list before being removed!
                    
            listPlayers.Remove(player);
        }
        //når der kun er en spiller tilbage
        void GameOver()
        {
            Console.WriteLine("Samlet status: ");
            foreach (Player p in listPlayersGameOver)
            {
                Console.WriteLine($" ... .Pladsen, Navn: {p.Name} Skæve i alt: {p.SkaeveAccumulated} point, ID: ");
                //Console.WriteLine($" ... .Pladsen, Navn: Skæve i alt: {p.SkaeveAccumulated} point, ID: ");
                //Console.WriteLine("test");
            }
            Console.ReadKey();
        }

        public void GodeEllerSkaeve()
        {
            //Player p;

           while (listPlayers.Count > 0)
            { 
                foreach (Player p in listPlayers.ToList()) //If you add ".ToList()" to your list (or the results of a LINQ query), you can remove "item" directly from "list" without the dreaded "Collection was modified; enumeration operation may not execute." error.
                {
                                        if (listPlayers.Count == 1) //en spiller tilbage, spillet slutter. 
                    {
                        Console.WriteLine($"{p.Name} du tabte!");

                        //sidste spiller tilføjes game over listen!
                        var player = listPlayers.FirstOrDefault(x => x.Name == p.Name);
                        listPlayersGameOver.Add(player);

                        GameOver();
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



                    //GodeEllerSkaeve();


                }
             }

        }
    }
}
