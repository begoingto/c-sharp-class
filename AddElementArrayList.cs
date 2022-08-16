using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class AddElementArrayList
    {
        static void MainBN()
        {
            int n;
            Console.Write("Enter n = ");
            n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int add;
            Console.Write("Enter number of element to add = ");
            add = int.Parse(Console.ReadLine());

            for (int i = n; i < n + add; i++)
            {
                Console.Write($"Enter new list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }
            Console.ReadKey();
        }
    }
}
