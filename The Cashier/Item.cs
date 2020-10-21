using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cashier
{
    class Item
    {
        private int id;
        public string title { get; set; }
        public int quantity { get; set; }
        public double price {get; set; }
        public double subtotal { get; set; }
        private string type;

        public Item(int id, string title, int quantity, double price, double subtotal, string type)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;
        }

        public string gettitle()
        {
            return title;
        }

        public int getquantity()
        {
            return quantity;
        }

        public string gettype()
        {
            return type;
        }

        public double getprice()
        {
            return price;
        }

        public double getsubtotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
    }
}
