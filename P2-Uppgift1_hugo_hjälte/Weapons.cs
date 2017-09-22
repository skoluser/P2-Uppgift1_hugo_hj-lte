using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Ärver från Items som är abstrakt
    abstract class Weapons : Items
    {
        // Instansvariabler damage & range
        protected int damage, range;

        // Konstruktor
        public Weapons(string name, string type, int value, int weight, int damage, int range) : base(name, type, value, weight)
        {            
        }

        // Här kan vi definiera info
        public override void Info()
        {
            Console.WriteLine(name+"\n"+type);
            Console.WriteLine("DMG " + damage + " RNG " + range);
            Console.WriteLine("VL " + value + "g" + " WT " + weight);
        }

        // Vi kan inte definiera Use() här eftersom alla weapons har olika uses
    }
}
