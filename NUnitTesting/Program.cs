﻿using NUnitTesting;
using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n1.Vending Machine");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        VendingMachine vendingmachine = new VendingMachine();
                        vendingmachine.Run();
                        break;


                }
            }
        }
    }
}
