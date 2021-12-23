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

        //automatic ID number
        private static int m_Counter = 0; 
        public int Id { get; set; }


        public Player(string name = "Anonymous", int point = 60)
        {
            Name = name;
            Point = point;

            this.Id = System.Threading.Interlocked.Increment(ref m_Counter); //part of the automatic ID number!
        }




    }
}
