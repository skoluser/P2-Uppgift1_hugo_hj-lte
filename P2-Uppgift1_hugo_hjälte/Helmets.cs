using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Ärver från SuitOfArmor för att helmets borde ingå där om du frågar mig
    class Helmets : SuitOfArmor
    {
        // Vädligt fin konstruktor
        public Helmets(string name, string type, int value, int weight, int defense, int resistance, string effect) : base(name, type, value, weight, defense, resistance, effect)
        {
        }

        // vi behöver inte override:a någonting eftersom vi ärver från SuitOfArmor
    }
}
