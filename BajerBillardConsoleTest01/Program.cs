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

            Console.WriteLine("skriv navn på spillere");
            players.Add(new Player(Console.ReadLine()));
            Console.WriteLine("skriv navn på spillere");
            players.Add(new Player(Console.ReadLine()));

            foreach (Player p in players)
            { 
                Console.WriteLine($"Navn: {p.Name}, Score: {p.Point} point"); 
            }

            Console.ReadKey();
        }
    }
}
