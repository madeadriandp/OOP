using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace oop2
{
    public class Order
    {
        public List<Cart> carts = new List<Cart>();

        public Order addItem(int item_id, int price, int quantity = 1, int discount=0)
        {
            carts.Add(new Cart(carts.Count + 1, price, quantity, discount));
            return this;
        }

        public Order removeItem(int item_id)
        {
            carts.RemoveAt(item_id - 1);
            return this;
        }

        public string addDiscount(string discount)
        {
            return (discount);
        }

        public int totalItems()
        {
            return carts.Count;
        }

        public int totalQuantity()
        {
            return carts.Sum(e => e.quantity);
        }

        public int totalPrice()
        {
            return carts.Sum(e => e.quantity * e.price);
        }

        public void showAll()
        {
            foreach (var item in carts)
            {
                Console.WriteLine($"item_id: {item.item_id}, price: {item.price}, quantity: {item.quantity}");
            }
            Console.WriteLine($"total item= {totalItems()} ");
            Console.WriteLine($"total price= {totalPrice()} ");
            Console.WriteLine($"discount= {addDiscount("50%")} ");
        }

        public void checkout()
        {
            using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@"D:\Users\bsi80091\Documents\dotnet\oop2\Cart_checkout.txt"))
        {
            foreach (var item in carts)
            {
            file.WriteLine($"item_id: {item.item_id}, price: {item.price}, quantity: {item.quantity}");
            
                }
            file.WriteLine($"total item= {totalItems()} ");
            file.WriteLine($"total price= {totalPrice()} ");
            file.WriteLine($"discount= {addDiscount("50%")} ");
            }
        } 
            
            // string Path = Path.
        






    }

    public class Cart
    {

        public int item_id { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int discount{get; set;}

        public Cart(int item_id, int price, int quantity, int discount)
        {
            this.item_id = item_id;
            this.price = price;
            this.quantity = quantity;
            this.discount = discount;

        }

    }

}