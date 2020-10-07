using System;

namespace studio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();
            Console.WriteLine($"My menu was last updated {myMenu.LastUpdated.ToShortDateString()}, here's what's on my menu: ");

            foreach (MenuItem item in myMenu.Items)
            {
                Console.WriteLine($"{item.Category}: {item.Name} - {item.Description} for ${item.Price}. It being new is {item.IsNew} and has an id of {item.Id}.");
            }
        }
    }
}
