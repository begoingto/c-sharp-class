using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class RandomNumberList
    {
        static void Main()
        {
            int n;
            List<int> list = new List<int>();
            Console.Write("Enter n value for random n=");
            n = int.Parse(Console.ReadLine());
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                int num = random.Next(n) + 1;
                if (list.Contains(num))
                {
                    i--;
                    continue;
                }
                list.Add(num);
            }
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine($"Number of list is list[{j}]={list[j]}");
            }
            Console.ReadKey();
        }
    }
}
