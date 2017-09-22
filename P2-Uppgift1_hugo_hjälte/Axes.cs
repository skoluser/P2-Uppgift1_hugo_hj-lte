using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Ärver från Weapons
    class Axes : Weapons
    {
        // Fin konstruktor
        public Axes(string name, string type, int value, int weight, int damage, int range) : base(name, type, value, weight, damage, range)
        {
            this.name = name;
            this.type = type;
            this.value = value;
            this.weight = weight;
            this.damage = damage;
            this.range = range;
        }

        // Här kan vi definiera use
        public override void Use()
        {
            Console.WriteLine("Attack:\n(1) Heavy swing: A slow but powerful strike. Deals double damage.");
            Console.WriteLine("(2) Warrior spirit: Temporarily increase defense and attack damage.");
        }
    }
}
