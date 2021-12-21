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
            Player player = new Player();
           
            player.AddPlayers();

            player.ShowPlayerList();

            player.GodeEllerSkaeve();

            Console.ReadKey();
        }

    
    }
}
