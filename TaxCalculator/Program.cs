using CalculatingTax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                CalculateIncomeTax myTaxCalculator = new CalculateIncomeTax();

                Console.WriteLine("Free Tax Calculator");
                Console.Write("\nInput your monthly salary (GROSS) in AUD: ");
                myTaxCalculator.grossSalary = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"\nYour monthly salary (NET) after tax deduction in AUD: {myTaxCalculator.TotalSalary(myTaxCalculator.grossSalary)}");
                

                Console.ReadLine();
        }
    }
}
