using System;
using System.Collections.Generic;
using System.Text;

namespace TheCashier
{
    class Item
    {
        private int id;
        public string title { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;
        public Item(int _id, string _title, int _quantity, string _type, double _price)
        {
            id = _id;
            title = _title;
            quantity = _quantity;
            type = _type;
            price = _price;
            subtotal = 0;
        }

        public string getTitle()
        {
            return title;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public string getType()
        {
            return type;
        }

        public double getPrice()
        {
            return price;
        }

        public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
    }
}
