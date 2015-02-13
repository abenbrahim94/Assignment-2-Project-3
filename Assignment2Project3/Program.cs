using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double HPR; // hourly pay rate
            double HW; // hours worked
            double GrossPay;
            double NetPay;
            const double TaxLow = 0.10;
            const double TaxHigh = 0.12;
            
            
            //Codes;
            Console.WriteLine("==========================Assignment2 project3=========================");
            Console.WriteLine("Salary Calculator ");
            Console.WriteLine("=======================================================================");
            Console.Write("\n");
            Console.WriteLine("Insert your Hourly Pay Rate:  ");
            HPR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert your the total amount of hours you worked ");
            HW = Convert.ToDouble (Console.ReadLine());
            Console.Write("\n");
            GrossPay = HW * HPR;
            Console.WriteLine("According to the Hourly Pay rate you entered of {0} And the Amount of hours you entered of {1}, Your Gross Pay is {2}", HPR, HW, GrossPay);
            if (GrossPay <= 300)
            {
                NetPay = GrossPay - TaxLow;
                Console.WriteLine("After Tax Deductions, Your Net Pay Is {0:c}", NetPay);
            }
            else if (GrossPay > 3.0)
            {
                NetPay = GrossPay - TaxHigh;
                Console.WriteLine("After Tax Deductions, Your Net Pay Is {0:c}", NetPay);
            }
            else
            {
                Console.WriteLine("Your Application Has Been Rejected!");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
