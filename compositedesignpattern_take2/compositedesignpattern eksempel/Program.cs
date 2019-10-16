using System;

namespace compositedesignpattern_eksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Shot a = new Shot("Small_sour", "Flavours: Apple, Cola, Peach, Liquorice etc.");
            Shot b = new Shot("Liqueur", "Vodka, Whisky, Tequila or Rum");
            Shot b = new Shot("Tequila ", "Served with Salt and a slice of Lemon");
            Shot b = new Shot("Russian Cocaine ", "Vodka served with a wedge of Lime, dipped in Sugar and Coffee powder");
            //  Supervisor b = new Supervisor("Supervisor Mary", 6);
            //   Supervisor c = new Supervisor("Supervisor Jerry", 7);
            //  Supervisor d = new Supervisor("Supervisor Bob", 9);
            // Worker e = new Worker("Worker Jimmy", 8);

            //set up the relationships
            //   b.AddSubordinate(a); //Tom works for Mary
            //  c.AddSubordinate(b); //Mary works for Jerry
            //  c.AddSubordinate(d); //Bob works for Jerry
            //  d.AddSubordinate(e); //Jimmy works for Bob

            //Jerry shows his happiness and asks everyone else to do the same
            if (c is IDrinklist)
                (c as IDrinklist).Printdrinkinfo();
        }
    }
}
