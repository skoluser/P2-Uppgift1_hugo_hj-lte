using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Abstrakt klass lol
    abstract class Items
    {
        // Varje item har en value, weight, type och name
        public string name;     // Name är public för att det används i klassen Inentory line 46
        protected string type;
        protected int value, weight;

        // Konstruktor
        public Items(string name, string type, int value, int weight)
        {
        }

        // Metod för info som definieras längre ner i "arv-trädet"
        public abstract void Info();
        // Läs ovan
        public abstract void Use();
    }
}
