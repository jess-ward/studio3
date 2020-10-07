using System;
namespace studio3
{
    public class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Categories Category { get; set; }
        public bool IsNew { get; set; }
        public int Id { get; }

        private static int nextId = 1;

     
        public MenuItem(string name, decimal price, string description, Categories category, bool isNew, int id)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
            Id = nextId;
            nextId++;
        }

        public enum Categories
        {
            Appetizer,
            MainCourse,
            Dessert
        }
    }
}

