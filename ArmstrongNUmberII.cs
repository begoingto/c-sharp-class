using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class ArmstrongNUmberII
    {
        static void MainCC()
        {
            for (int i = 0; i <= 10000; i++)
            {
                double sum = 0;
                foreach (char item in i.ToString().ToCharArray())
                {
                    sum += Math.Pow(int.Parse(item.ToString()), i.ToString().Length);
                }
                if(sum==i)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
