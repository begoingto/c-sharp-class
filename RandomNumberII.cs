using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class RandomNumberII
    {
        static void MainMKL()
        {
            int n;
            Console.Write("Enter n=");
            n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
                list.Add(i);
            List<int> ls = new List<int>();
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int index = r.Next(list.Count);
                ls.Add(list[index]);
                list.RemoveAt(index);
                Console.WriteLine($"List[{i}] = " + ls[i]);
            }
            Console.ReadKey();
        }
    }
}
