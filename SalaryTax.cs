using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, bonus;
            int spouse, children;

            Console.WriteLine("************** Input value Required **************\n");

            Console.Write("Enter Salary =");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Bonus =");
            bonus = double.Parse(Console.ReadLine());
            Console.Write("Enter Spouse =");
            spouse = int.Parse(Console.ReadLine());
            Console.Write("Enter Children =");
            children = int.Parse(Console.ReadLine());
            if (salary>=0 && bonus >=0)
            {
                int s=0;
                s = spouse >= 1 ? 1 : s;

                if (children >= 9)
                {
                    children = 9;
                }
                else if(children <= 0)
                {
                    children = 0;
                }
                double family = 150000 * (spouse + children);
                double tax, l_salary;
                salary= salary - family;
                if (salary <= 1200000)
                {
                    tax = 0;
                }
                else if (salary <= 2000000)
                {
                    tax = salary * 0.05 - 60000;
                }
                else if(salary <= 8500000)
                {
                    tax = salary * 0.1 - 160000;
                }
                else if(salary <= 12500000)
                {
                    tax = salary * 0.15 - 585000;
                }
                else
                {
                    tax = salary * 0.2 - 1210000;
                }

                tax += bonus * 0.2;
                l_salary = (salary + family + bonus) - tax;

                Console.WriteLine("\n************** Result Salary *********************");
                Console.WriteLine("*");
                Console.WriteLine($"*\tTax         ={tax:#,##0.##} R");
                Console.WriteLine($"*\tLast Salary ={l_salary:#,##0.##} R");
                Console.WriteLine("*");
                Console.WriteLine("*************** End Result Salary ****************");
            }
            else
            {
                string invalide= salary<0? $"Salary :{salary}" : $"Bonus {bonus}";
                Console.WriteLine("******************************************************");
                Console.WriteLine("*");
                Console.WriteLine($"*\t Sorry your value {invalide} invalided.");
                Console.WriteLine("*");
                Console.WriteLine("******************************************************");
            }

            Console.ReadKey();
        }
    }
}
