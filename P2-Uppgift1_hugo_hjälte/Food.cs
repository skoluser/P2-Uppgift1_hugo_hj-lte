using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    class Food : Consumables
    {
        // Instansvariabler 'stat buffs'
        private int strength, magic, defense, resistance;

        public Food(string name, string type, int value, int weight, int heal, int strength, int magic, int defense, int resistance) : base(name, type, value, weight, heal)
        {
            this.name = name;
            this.type = type;
            this.value = value;
            this.weight = weight;
            this.heal = heal;
            this.strength = strength;
            this.magic = magic;
            this.defense = defense;
            this.resistance = resistance;
        }

        // Här definierar vi Use()
        public override void Use()
        {
            Console.WriteLine("Effect:");
            Console.WriteLine("STR +" + strength + " MAG +" + magic);
            Console.WriteLine("DEF +" + defense + " RES +" + resistance);
        }
    }
}
