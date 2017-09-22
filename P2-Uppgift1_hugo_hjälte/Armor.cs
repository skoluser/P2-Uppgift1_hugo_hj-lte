using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Klassen ärver från Items som är abstrakt
    abstract class Armor : Items
    {
        // Instansvariabel defense och resistance (resistance motverkar magic damage obviously)
        protected int defense, resistance;

        // Fin konstruktor
        public Armor(string name, string type, int value, int weight, int defense, int resistance) : base(name, type, value, weight)
        {
        }

        // Här kan vi definiera info
        public override void Info()
        {
            Console.WriteLine(name + "\n" + type);
            Console.WriteLine("DEF " + defense + " RES " + resistance);
            Console.WriteLine("VL " + value + "g" + " WT " + weight);
        }

        // Vi kan inte definiera Use() här eftersom all rustning har olika egenskaper
    }
}
