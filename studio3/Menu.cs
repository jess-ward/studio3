using System;
using System.Collections.Generic;

namespace studio3
{
    public class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu()
        {
            LastUpdated = DateTime.Now;
            Items = new List<MenuItem>
            {
                new MenuItem("Fried Chicken", 12.00m, "Winner winner chicken dinner", MenuItem.Categories.MainCourse, true, 0),
                new MenuItem("Burger", 15.50M, "Fresh, never frozen", MenuItem.Categories.MainCourse, false, 0),
                new MenuItem("Bruschetta", 10.00m, "Grilled garlic bread topped with fresh tomatoes, basil, and balsamic vinegar", MenuItem.Categories.Appetizer, true, 0),
                new MenuItem("Carrot Cake", 7.50m, "My sons first birthday cake made from scratch", MenuItem.Categories.Dessert, false, 0),
                new MenuItem("Scrabble Pie", 7.00m, "To commemorate our Scrabble Scorer Assignment", MenuItem.Categories.Dessert, true, 0)
            };
        }

    }
}
