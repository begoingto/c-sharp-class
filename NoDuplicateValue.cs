using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class NoDuplicateValue
    {
        static void MainVV()
        {
            //Random random = new Random();
            //int num = random.Next(10)+1;

            int n;
            Console.Write("Enter number of number = ");
            n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {

                Console.Write($"Enter list[{i}]= ");
                int temp = int.Parse(Console.ReadLine());
                if (list.Contains(temp))
                {
                    i--;
                    continue;
                }

                list.Add(temp);
            }

            Console.WriteLine("-------------------------");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"List[{i}]= {list[i]}");
            Console.ReadKey();
        }
    }
}
