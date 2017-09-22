using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    class Shields : Armor
    {        
        // Fin konstruktor
        public Shields(string name, string type, int value, int weight, int defense, int resistance) : base(name, type, value, weight, defense, resistance)
        {
            this.name = name;
            this.type = "Shield";
            this.value = value;
            this.weight = weight;
            this.defense = defense;
            this.resistance = resistance;
        }

        public override void Use()
        {
            Console.WriteLine("Use:\n(1) Deflect: Deflect attacks. Powerful attacks will be \ntaken at reduced damage.");
            Console.WriteLine("(2) Shield bash: Stagger opponents.");
        }
    }
}
