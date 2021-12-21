using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajerBillardConsoleTest01
{
    internal class Player
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public Player(string name = "Anonymous", int point = 60)
        {
            Name = name;
            Point = point;
        }
    }
}
