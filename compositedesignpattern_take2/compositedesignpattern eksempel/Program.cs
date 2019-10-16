using System;

namespace compositedesignpattern_eksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Shot a = new Shot("vodka_juice", "vodkaandjuice");
         //   Supervisor b = new Supervisor("Supervisor Mary", 6);
         //   Supervisor c = new Supervisor("Supervisor Jerry", 7);
          //  Supervisor d = new Supervisor("Supervisor Bob", 9);
            Worker e = new Worker("Worker Jimmy", 8);

            //set up the relationships
            a.Addshot()//Tom works for Mary
          //  c.AddSubordinate(b); //Mary works for Jerry
          //  c.AddSubordinate(d); //Bob works for Jerry
          //  d.AddSubordinate(e); //Jimmy works for Bob

            //Jerry shows his happiness and asks everyone else to do the same
            if (c is IDrinklist)
                (c as IDrinklist).Printdrinkinfo();
        }
    }
}
