using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectConsoleApp
{
    internal class ProductApp
    {
       static void Main()
        {
            int n;
            List<Product> products = new List<Product>();
            /*products.Add(new Product() { id= 1, name= "Coca",qty= 15,unitPrice= 1.50});
            products.Add(new Product() { id= 2, name= "Sprite",qty= 32,unitPrice= 1.28});
            products.Add(new Product() { id= 3, name= "Anchor",qty= 57,unitPrice= 2.23});*/
            Console.WriteLine("**************** PRODUCT APPLICATION MANAGEMENT ****************");
            while (true)
            {
                n = products.Count() > 0 ? InitMenu() : 1;
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine("******** ADD PRODUCT *******");
                        Product product = new Product();
                        product.Input(products);
                        products.Add(product);
                        break;
                    case 2:
                        ListProduct(products);
                        break;

                    case 3:
                        ListProduct(products);
                        Product prResult = FindProduct(products);
                        Console.Clear();
                        Line();
                        Console.WriteLine(Heading());
                        Line();
                        if (prResult != null)
                        {
                            Console.WriteLine(prResult);
                            prResult.Edit(prResult);
                            Console.Clear();
                            Line();
                            Console.WriteLine("############ Product has been updated successful ###############");
                            Line();
                            Console.WriteLine(Heading());
                            Line();
                            Console.WriteLine(prResult);
                        }
                        else
                        {
                            Console.WriteLine("Data not found".PadLeft(35));
                        }
                        Line();
                        break;
                    case 4:
                        ListProduct(products);
                        Product fProduct = FindProduct(products);
                        Console.Clear();
                        products.Remove(fProduct);
                        Line();
                        Console.WriteLine("############ Product has been deleted successful ###############");
                        Line();
                        ListProduct(products);
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static Product FindProduct(List<Product> products)
        {
            Console.WriteLine("******** FIND PRODUCT *******");
            int id;
            Console.Write("Enter product ID= ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Result:");
            Product prResult = products.Find(
                delegate (Product pro)
                {
                    return pro.id == id;
                }
            );
            return prResult;
        }

        private static void Line()
        {
            Console.WriteLine("----------------------------------------------------------------");
        }

        private static int InitMenu()
        {
            int n;
            Console.WriteLine("Please select menu");
            Console.WriteLine("1.Enter number 1 for add new product.");
            Console.WriteLine("2.Enter number 2 for list product.");
            Console.WriteLine("3.Enter number 3 for edit product.");
            Console.WriteLine("3.Enter number 4 for Delete product.");
            Console.WriteLine("3.Enter number 5 for Clean screen.");
            Console.WriteLine("3.Enter number not 1 2 for exit.");
            Console.Write("Enter Menu: ");
            n = int.Parse(Console.ReadLine());
            return n;
        }

        private static void ListProduct(List<Product> products)
        {
            double total = 0;
            Console.WriteLine("********PRODUCT LIST*******");
            Line();
            Console.WriteLine(Heading());
            Line();
            foreach (Product pr in products)
            {
                Console.WriteLine(pr);
                total += pr.unitPrice * pr.qty;
            }
            Line();
            Console.WriteLine($"Tatal Amount: {total:c2}");
            Console.WriteLine("---------------------");
        }

        private static string Heading()
        {
            return "ID" +
                   "Name".PadLeft(15) +
                   "QTY".PadLeft(15) +
                   "Unit Price".PadLeft(15) +
                   "Amount".PadLeft(15);
        }
    }
}
