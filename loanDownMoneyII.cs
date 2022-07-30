using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class loanDownMoneyII
    {
        static void MainC()
        {
            int months;
            double rate, loan, interestRate, total_installment = 0, total_interest = 0;
            Console.Write("Enter Money Loan=$");
            loan = double.Parse(Console.ReadLine());
            Console.Write("Enter inerest rate=%");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter month=");
            months = int.Parse(Console.ReadLine());
            interestRate = (rate / 12) / 100;
            DateTime now = DateTime.Now;
            Console.WriteLine($"Now: {now:dd-MM-yyyy}");


            Console.WriteLine();
            Console.Write("Month".PadRight(10));
            Console.Write("Installment".PadRight(15));
            Console.Write("Principle".PadRight(15));
            Console.Write("Interest".PadRight(15));
            Console.Write("Detbpayment".PadRight(15));
            double principle = loan / months;
            double interest2,installment, detb = loan;
            Console.WriteLine();

            for (int i = 1; i <=months; i++)
            {
                interest2 = detb * interestRate;
                installment = principle + interest2;
                detb -= principle;
                now = now.AddMonths(1);

                if (i==months)
                {
                    installment = Math.Round(principle, 2) + Math.Round(interest2, 2);
                }
                total_installment += installment;
                Console.Write($"{now:dd-MM-yyyy}".PadRight(10,'-'));
                Console.Write($"{installment:c2}".PadLeft(15,'-'));
                Console.Write($"{principle:c2}".PadLeft(15,'-'));
                Console.Write($"{interest2:c2}".PadLeft(15,'-'));
                Console.Write($"{detb:c2}".PadLeft(15,'-'));
                Console.WriteLine();
            }
            total_interest = total_installment - loan;
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"Total interest: {total_interest:c2}");
            Console.WriteLine($"Total installment: {total_installment:c2}");
            Console.ReadKey();
        }
    }
}
