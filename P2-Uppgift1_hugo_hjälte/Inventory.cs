using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    // Denna klass används av Program.cs
    class Inventory
    {
        // Skapar ett register för items
        private List<Items> reg = new List<Items>();
        
        // Konstruktor
        public Inventory()
        {            
            // Skapar ett av varje item
            Swords brevöppnare = new Swords("Brevöppnare", "Svärd, typ", 89, 2, 1, 0);
            Lances sopkvast = new Lances("Sopkvast", "Lans", 15, 5, 1, 3);
            Axes brandyxa = new Axes("Brandyxa", "Yxa", 168, 25, 8, 1);
            SuitOfArmor pyjamas = new SuitOfArmor("Pyjamas", "Rustning", 55, 10, 5, 20, "+15 Cold resistance.");
            Helmets cykelhjälm = new Helmets("Cykelhjälm", "Hjälm", 333, 0, 100, 0, "Immune to stuns.");
            Shields kartong = new Shields("Kartong", "Sköld", 0, 0, 0, 100);
            Potions blekningsmedel = new Potions("Blekningsmedel", "Potion", 32, 10, -100, "Gives a quick end to the suffering that is existence");
            Food skogaholmslimpa = new Food("Skogaholmslimpa", "Frukost", 24, 2, 10, 0, 0, 10, 10);
            Helmets kastrull = new Helmets("Kastrull", "Hjälm", 35, 30, 80, 80, "+10 Charisma.");

            // Lägger till ovannämnda items i registret
            reg.Add(brevöppnare);
            reg.Add(sopkvast);
            reg.Add(brandyxa);
            reg.Add(pyjamas);
            reg.Add(cykelhjälm);
            reg.Add(kartong);
            reg.Add(blekningsmedel);
            reg.Add(skogaholmslimpa);
            reg.Add(kastrull);
        }

        // Listar alla items i registret
        public void ListItems()
        {
            // För varje item i registret
            foreach (Items item in reg)
            {
                // Skriv namnet på item:et samt numrera det efter dess index i registret
                Console.WriteLine(reg.IndexOf(item)+". "+item.name);
            }
        }

        // Ger Info() och Use() för ett item
        public void GetItemDescription(int itemIndex)
        {
            reg[itemIndex].Info();
            Console.WriteLine();
            reg[itemIndex].Use();
        }

        // Ger antalet items i registret
        public int RegisterUpperLimit()
        {
            return reg.Count();            
        }

    }
}
