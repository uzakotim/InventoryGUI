using System;

namespace InventoryGUI{
    class Item{
        public string Quantity { get; set; }
        public string Name { get; set; }
        public Item(string name, string quantity){
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}