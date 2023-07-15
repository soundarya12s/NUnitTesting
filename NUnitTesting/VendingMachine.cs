using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class VendingMachine
    {

        int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public void CalculateChange(int amount)
        {
            int noteCount = 0;

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    noteCount = amount / notes[i];
                    amount %= notes[i];

                    Console.WriteLine(notes[i] + " Rs notes: " + noteCount);
                }
            }
        }

        public void Run()
        {
            Console.WriteLine("Enter the change amount:");
            int changeAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minimum number of notes needed:");
            CalculateChange(changeAmount);
        }
    }
}
