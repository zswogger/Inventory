using System;

namespace Inventory
{
    [Serializable]
    public class Item
    {
        private string productNumber;
        private string name;
        private string manufacturer;
        private int quantity;
        private double price;
        private string location;
        private string description;

        public Item(string productNumber, string name, string manufacturer, int quantity, double price, string location, string description)
        {
            this.productNumber = productNumber;
            this.name = name;
            this.manufacturer = manufacturer;
            this.quantity = quantity;
            this.price = price;
            this.location = location;
            this.description = description;
        }

        public Item()
        {

        }

        public Item copy(Item item)
        {
            Item newItem = new Item();

            newItem.productNumber = item.productNumber;
            newItem.name = item.name;
            newItem.manufacturer = item.manufacturer;
            newItem.quantity = item.quantity;
            newItem.price = item.price;
            newItem.location = item.location;
            newItem.description = item.description;

            return newItem;
        }

        public string ProductNumber { get => productNumber; set => productNumber = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Location { get => location; set => location = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
    }
}
