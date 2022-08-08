using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class ArmStrongNumber
    {
        static void Main()
        {
            int i,sum=0;
            Console.Write("Enter value of n=");
            i=int.Parse(Console.ReadLine());
            int digit = i.ToString().Length;
            char[] num=i.ToString().ToCharArray();

            foreach (var item in num)
            {
                sum+=(int)Math.Pow(int.Parse(item.ToString()), digit);
            }
            if (sum==i)
            {
                Console.WriteLine($"This number Armstrong Number");
            }
            else
            {
                Console.WriteLine($"Not armstrong number");
            }
            Console.ReadKey();
        }
    }
}
