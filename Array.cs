using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class Array
    {
        static void Main()
        {
            int[] a = {1,2, 3 };
            double[] b = {1.5,2.6,3.8};
            string[] names = {"Vuthy","Layhak","Kimheang"};

            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            foreach(string name in names)
                Console.WriteLine(name);

            foreach (double item in b)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
