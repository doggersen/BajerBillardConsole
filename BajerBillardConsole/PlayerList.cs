using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajerBillardConsole
{
    public class PlayerList
    {
        public List<Player>? Players { get; set;}

        public void AddPlayer()
        {
            Players.Add(new Player("Jimmy", 50));
           
        }

    }
}
