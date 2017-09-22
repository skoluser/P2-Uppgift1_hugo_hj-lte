using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    abstract class Consumables : Items
    {
        // Instansvariabel 'heal'
        protected int heal;
        
        // Finfin konstruktor
        public Consumables(string name, string type, int value, int weight, int heal) : base(name, type, value, weight)
        {
        }

        // Override:ar Info()
        public override void Info()
        {
            Console.WriteLine(name + "\n" + type);
            Console.WriteLine("HEAL: "+ heal);
            Console.WriteLine("VL " + value + "g" + " WT " + weight);
        }
    }
}
