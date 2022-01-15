using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTesting
{
    public class Player
    {
        public string Name { get; set; }
        public string ScoreGuess { get; set; }
        public int BetAmount { get; set; } 

        //public Player(string name, string scoreGuess, int betAmount)
        //{
        //    Name = name;
        //    ScoreGuess = scoreGuess;
        //    BetAmount = betAmount;

        //}

       
        public void ShowListFromPlayerClass()
        {
            Game game = new Game();
            Console.WriteLine("denne liste er fra Player klassen!:");
            foreach (var player in game.GetList())
            {
                Console.WriteLine(player.Name);
                Console.WriteLine(player.ScoreGuess);
                Console.WriteLine(player.BetAmount);
                Console.WriteLine("*******************");
            }
                

        }
    }
}
