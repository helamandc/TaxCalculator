using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTax
{
    public class CalculateIncomeTax
    {
        
        public double grossSalary;
        public double netSalary;
        public double taxPercentage = 0.10;

        public double TotalSalary(double gross)
        {
            netSalary = gross - (gross * taxPercentage);
            return netSalary;
        }

        [Test]
        public void TestTaxCalculator()
        {
            //Arrange
            grossSalary = 100.00;
            //Act
            netSalary = grossSalary - (grossSalary * taxPercentage);
            //Assert
            Assert.AreEqual(90, netSalary);


        }

    }
}
