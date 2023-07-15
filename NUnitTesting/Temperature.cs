using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class Temperature
    {

        public void ConvertTemperature()
        {
            Console.WriteLine("1.Celsius to Fahrenheit:\n2.Fahrenheit to Celsius:");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Enter the value of celsius");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input * (9 / 5) + 32);
            }
            if (ch == 2)
            {
                Console.WriteLine("Enter the value of Fahrenheit");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((input - 32) * (5 / 9));
            }
        }
    }
}
