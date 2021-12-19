using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajerBillardConsole
{
    public class Player
    {
        public string? Name { get; set; }
        public int? Points { get; set; }

        public Player (string name, int points = 60)
        {
            Name = name;
            Points = points;
        }
        

    }
}
