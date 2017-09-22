using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Klassen ärver från Armor
    class SuitOfArmor : Armor
    {
        // Instansvariabel 'effect' som förklarar vad rustningen ger för effekt
        protected string effect;

        // Väldigt fin konstruktor
        public SuitOfArmor(string name, string type, int value, int weight, int defense, int resistance, string effect) : base(name, type, value, weight, defense, resistance)
        {
            this.name = name;
            this.type = type;
            this.value = value;
            this.weight = weight;
            this.defense = defense;
            this.resistance = resistance;
            this.effect = effect;
        }

        // Use definieras
        public override void Use()
        {
            Console.WriteLine("Effect: \n"+effect);
        }
    }
}
