namespace BajerBillardConsoleTest01
{
    internal class Player
    {
        public string Name { get; set; }
        public int Point { get; set; } = 60;

        public int Plads { get; set; }
        public int SkaeveAccumulated { get; set; }

        //automatic ID number
        private static int m_Counter = 0;
        public int Id { get; set; }


        public Player(string name = "Anonymous")
        {
            Name = name;
            
            this.Id = System.Threading.Interlocked.Increment(ref m_Counter); //part of the automatic ID number!
        }




    }
}
