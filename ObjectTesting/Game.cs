using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTesting
{
    internal class Game
    {
        static List<Player> players = new List<Player>();
        public List<Player> GetList()
        {
            return players; 
        }


        //public Game()
        //{
        //    players.Add(new Player("martin", "2-1", 100));
        //    players.Add(new Player("Jimmy", "0-0", 50));
        //    players.Add(new Player("Henrik", "4-3", 500));
        //}
        
        public void PopulateList()
        {
            //players.Add(new Player({ Name = "martin", BetAmount = 100, ScoreGuess = "2-1" })
            //players.Add(new Player())
            //players.Add(new Player());

             players.Add(new Player { Name = "nartin", BetAmount = 100, ScoreGuess = "2-1" });
             players.Add(new Player{ Name = "jimmy", BetAmount = 200, ScoreGuess = "3-1" });
        }

        public void ShowList()
        {
            foreach (var player in players)
            {
                Console.WriteLine("******************");
                Console.WriteLine(player.Name);
                Console.WriteLine(player.ScoreGuess);
                Console.WriteLine(player.BetAmount);
                
            }
        }

        public void ShowListAGain()
        {
            Console.WriteLine("the below list is also from the Game class:");
            foreach (var player in players)
            {
                
                Console.WriteLine(player.Name);
                Console.WriteLine(player.ScoreGuess);
                Console.WriteLine(player.BetAmount);
                Console.WriteLine("******************");
            }
        }


    }
}
