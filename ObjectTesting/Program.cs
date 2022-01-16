using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.PopulateList();

            game.ShowList();
            game.ShowListAGain();
            

            Player player = new Player();

            player.ShowListFromPlayerClass();


            Console.ReadKey();
        }
    }
}
