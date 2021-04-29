using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Enumeração_e_Composição.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int Quantity, double Price, Product Product)
        {
            quantity = Quantity;
            price = Price;
            product = Product;
        }

       public double subTotal()
        {
            return price * quantity;
        }

        public override string ToString()
        {
            return product.name +
                ", $"+
                price.ToString("F2")+
                ", Quantity: "+
                quantity+
                ", Subtotal: $"+
                subTotal().ToString("F2");
        }
    }
}
