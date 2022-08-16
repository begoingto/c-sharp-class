using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class UniqueNumber
    {
        static void MainBB()
        {
            int[] a = { 1, 2, 3, 5, 2, 1, 2, 3 };
            foreach (int j in a)
            {
                int c = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]==j)
                    {
                        c++;
                    }
                }
                if (c==1)
                {
                    Console.WriteLine(j);
                }
            }

            Console.ReadKey();
        }
    }
}
