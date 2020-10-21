using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Big_Domashka
{
    public class Product
    {
        public Guid id;
        public string name { get; set; }
        public string description { get; set; }
        public double amount { get; set; }
        public decimal price { get; set; }
        public List<Order> listOfOrders = new List<Order>();
        static public Product Add()
        {
            Product Ghost_order = new Product();
            Ghost_order.id = Guid.NewGuid();
            Console.WriteLine("Введите имя продукта");
            Ghost_order.name = Console.ReadLine();
            Console.WriteLine("Введите цену продукта");
            Ghost_order.price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество товара");
            Ghost_order.amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите описание товара");
            Ghost_order.description = Console.ReadLine();

            return Ghost_order;
        }
        static public Product Add(string name, decimal price, double amount, string description)
        {
            Product Ghost_order = new Product();
            Ghost_order.id = Guid.NewGuid();
            Ghost_order.name = name;
            Ghost_order.price = price;
            Ghost_order.amount = amount;
            Ghost_order.description = description;
            return Ghost_order;
        }
        public static void Delete(string name,ref Shop shop)
        {
            for (int i = 0; i < shop.listOfProducts.Count; i++)
            {
                
                if (name == shop.listOfProducts.ElementAt<Product>(i).name)
                {
                    shop.listOfProducts.RemoveAt(i);
                    break;
                }

            }
            
        }
    }
}
