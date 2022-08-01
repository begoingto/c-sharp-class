using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class MountainRange
    {
        static void Main()
        {
            int a;
            Console.Write("Enter n = ");
            a = int.Parse(Console.ReadLine());
            int[] n = new int[a];
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"Enter a[{i}] = ");
                n[i] = int.Parse(Console.ReadLine());
            }
            int t = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (i>=1)
                {
                    if(i< n.Length -1)
                    {
                        if (n[i - 1] < n[i] && n[i] > n[i + 1])
                        {
                            t++;
                        }
                    }
                    else
                    {
                        if (n.Last() > n[i-1])
                        {
                            t++;
                        }
                    }
                }
                else
                {
                    if (n[0] > n[1])
                    {
                        t++;
                    }
                }

                Console.WriteLine($" last value 1={n.Last()} value 2={n[n.Length-1]}");
            }
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
