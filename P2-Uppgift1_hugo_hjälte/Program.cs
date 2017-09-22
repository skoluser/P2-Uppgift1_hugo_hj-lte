using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Uppgift1_hugo_hjälte
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett objekt av klassen inventory
            Inventory inventory = new Inventory();

            Console.WriteLine("*~~~~ Välj ett föremål du vill veta mer om! ~~~~*");
            Console.WriteLine();
            // Listar items
            inventory.ListItems();

            // Tar in användarens val, felhanterar och annat smått och gott
            while (true)
            {
                // Användarens val
                string userInput = Console.ReadLine();
                // Integer för TryParse
                int choice;
                // TryParse
                bool result = int.TryParse(userInput, out choice);

                // Om användaren har gjort ett giltigt val (dvs inom item-listans gränser)
                if (result && choice > -1 && choice < inventory.RegisterUpperLimit())
                {
                    Console.WriteLine();
                    inventory.GetItemDescription(choice);   // Kolla klassen Inventory line 50
                }

                else
                    Console.WriteLine("Ogiltig inmatning");

                Console.ReadLine();
                Console.WriteLine();

                inventory.ListItems();
            }                   
        }

    }
}
