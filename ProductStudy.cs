using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectConsoleApp
{
    internal class ProductStudy
    {
        private int Id;
        public int getId()
        {
            return Id;
        }
        public int setId()
        {
            return Id;
        }

        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double Amount{
            get => Qty * Price;
        }

        public void Input()
        {
            Console.Write("Enter ID = ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name = ");
            Name = Console.ReadLine();
            Console.Write("Enter qty = ");
            Qty = int.Parse(Console.ReadLine());
            Console.Write("Enter unit price= ");
            Price = double.Parse(Console.ReadLine());
        }
    }
}
