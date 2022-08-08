using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class MontainerRangeII
    {
        static void MainNB()
        {
            int a;
            Console.Write("Enter n = ");
            a = int.Parse(Console.ReadLine());
            int[] height = new int[a];
            for (int i = 0; i < height.Length; i++)
            {
                Console.Write($"Enter a[{i}] = ");
                height[i] = int.Parse(Console.ReadLine());
            }
            int peaks = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (i==0)
                {
                    if (height[0] > height[1])
                    {
                        peaks++;
                        i++;
                    }
                        
                }
                else if (i== height.Length -1)
                {
                    if (height[i]> height[i-1])
                        peaks++;
                }
                else
                {
                    if (height[i] > height[i-1] && height[i] > height[i+1])
                    {
                        peaks++;
                        i++;
                    }
                }
            }
            Console.WriteLine($"Height mountain is: {peaks}");
            Console.ReadKey();
        }
    }
}
