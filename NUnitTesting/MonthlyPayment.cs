using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {

        public void GetAmount()
        {
            Console.Write(" Enter the principal : ");
            Double p = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter the years : ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter the percent interest compounded : ");
            decimal R = Convert.ToDecimal(Console.ReadLine());

            double r = Convert.ToDouble(Decimal.Divide(R, Convert.ToDecimal(1200)));  // r = R/(1200)
            double n = Convert.ToDouble(12) * y; // n = 12*y
            double result = (p * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine(result);
        }
    }
}
