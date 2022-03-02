using System.Security.Cryptography;
using System;

namespace CustomerService
{
    public class InterestRate
    {
        private double CalculateInterestRate()
        {
            double inflationRate = GetInflationRate();

            double interestRate = inflationRate + 1.75;

            return interestRate;
        }
        private  double GetInflationRate()
        {

            Random rnd = new Random();

            int integerPart = rnd.Next(4, 6);
            double nonIntegerPart = rnd.NextDouble();

            return TruncateDecimalPart((double)(integerPart + nonIntegerPart), 2); ;
        }
        private  double TruncateDecimalPart(double value, int decimalPoint)
        {
            value = value * Math.Pow(10, decimalPoint);
            value = Math.Floor(value);
            value = value / Math.Pow(10, decimalPoint);
            return value;
        }
    }
}
