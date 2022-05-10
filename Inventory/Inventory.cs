using System;
using System.Collections.Generic;

namespace Inventory
{
    [Serializable]
    public class Inventory
    {
        private List<Item> catalog = new List<Item>();
        Item notFound = new Item("Not Found", "Not Found", "Not Found", 0, 0, "Not Found", "Not Found"); // Used in case a value is searched for that does not exist

        public Inventory()
        {

        }

        public void add(Item item)
        {
            catalog.Add(item);
        }
        public void remove(string productNumber) // Removes item from inventory
        {
            catalog.Remove(catalog.Find(Item => Item.ProductNumber == productNumber));
        }

        public void restock(string productNumber, int quantity) // Restocks an item based on item productNumber and given quantity
        {
            catalog[catalog.FindIndex(Item => Item.ProductNumber == productNumber)].Quantity = quantity;
        }

        public Item searchID(string productNumber) // Search for item by productNumber
        {
            if (catalog.Contains(catalog.Find(Item => Item.ProductNumber == productNumber))) // If item is found
            {
                return catalog.Find(Item => Item.ProductNumber == productNumber);
            }

            return notFound;
        }

        public Item searchPrice(double price) // Search for item by price
        {
            if (catalog.Contains(catalog.Find(Item => Item.Price == price))) // If item is found
            {
                return catalog.Find(Item => Item.Price == price);
            }

            return notFound;
        }

        public Item searchQuantity(int quantity)  // Search for item by productNumber
        {
            if (catalog.Contains(catalog.Find(Item => Item.Quantity == quantity))) // If item is found
            {
                return catalog.Find(Item => Item.Quantity == quantity);
            }

            return notFound;
        }



        internal List<Item> Catalog { get => catalog; set => catalog = value; }
    }
}
