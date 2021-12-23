using System;

namespace BajerBillardConsoleTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            //game.AddPlayers(Console.ReadLine());

            game.AddPlayers("Jimmy");
            game.AddPlayers("Martin");
            game.AddPlayers("Poul");

            game.ShowPlayerList();

            game.GodeEllerSkaeve();

            Console.ReadKey();
        }


    }
}
