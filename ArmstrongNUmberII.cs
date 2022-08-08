using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class ArmstrongNUmberII
    {
        static void Main()
        {
            for (int i = 0; i < 10000; i++)
            {
                int d = i.ToString().Length;
                char[] ch = i.ToString().ToCharArray();
                double sum = 0;
                foreach (char item in ch)
                {
                    int num = (int)item - 48;
                    sum += Math.Pow(num, d);
                }
                if(sum==i)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
