using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    class Potions : Consumables
    {
        //Instansvariabel 'effect' som förklarar vad vår consumable gör
        private string effect;

        // Finfin konstruktor
        public Potions(string name, string type, int value, int weight, int heal, string effect) : base(name, type, value, weight, heal)
        {
            this.name = name;
            this.type = type;
            this.value = value;
            this.weight = weight;
            this.heal = heal;
            this.effect = effect;
        }

        // Här definierar vi Use()
        public override void Use()
        {
            Console.WriteLine("Effect: \n"+effect);
        }
    }
}
