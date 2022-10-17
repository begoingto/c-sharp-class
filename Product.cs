using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectConsoleApp
{
    internal class Product
    {
        public int id;
        public string name;
        public int qty;
        public double unitPrice;

        public Product()
        {
            id = 1;
            name = "Coca";
            qty = 2;
            unitPrice = 1.50;
        }

        public Product(int id, string name, int qty, double unitPrice)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }

        public void Input(List<Product> products)
        {
            id = products.Count() + 1;
            Console.WriteLine($"ID = {id}");
            //id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name = ");
            name = Console.ReadLine();
            Console.Write("Enter qty = ");
            qty = int.Parse(Console.ReadLine());
            Console.Write("Enter unit price= ");
            unitPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");
        }

        public Product Edit(Product product)
        {
            Console.WriteLine("\r\n############ UPDATING PRODUCT ###############");
            Console.WriteLine($"Update ID = {product.id}");
            Console.Write("Edit Name = ");
            product.name = Console.ReadLine();
            Console.Write("Edit qty = ");
            product.qty = int.Parse(Console.ReadLine());
            Console.Write("Edit unit price= ");
            product.unitPrice = double.Parse(Console.ReadLine());
            return this;
        }

        public override string ToString()
        {
            string p = $"{id:000}";
            p += $"{name}".PadLeft(15);
            p += $"{qty}".PadLeft(14);
            p += $"{unitPrice:c2}".PadLeft(10);
            p += Amount().PadLeft(19);
            return p;
        }

        public string Amount()
        {
            return $"{(qty * unitPrice):c2}";
        }
    }
}
