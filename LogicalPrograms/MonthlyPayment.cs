using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Enter the Principal : ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Year : ");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate : ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Monthly Payment is " + monthlyPayment(principal, year, rate));
        }
        public static double monthlyPayment(double p, double y, double r)
        {
            double n = 12 * y;
            double rpp = r / (12 * 100);
            double payment = p * rpp / (1 - Math.Pow((1 + rpp), -n));
            return payment;
        }
    }
}
