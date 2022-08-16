using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class AmicableNumber
    {
        static void MainAmm()
        {
            for (int i = 1; i <=10000; i++)
            {
                int t = Sum(i);
                if (Sum(t)== i && i < t)
                {
                    Console.WriteLine($"{i}-{t}");
                }
            }
            Console.ReadKey();
        }

        static int Sum(int j)
        {
            int s = 0;
            for (int i = 1; i < j; i++)
            {
                if (j%i==0)
                {
                    s += i;
                }
            }
            return s;
        }
    }
}
