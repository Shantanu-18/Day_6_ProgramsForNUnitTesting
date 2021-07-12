using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    public class vendingMachine
    {
        public static void VendingMachine()
        {
            int amount;
            Console.Write("Enter amount you want change for: ");
            amount = int.Parse(Console.ReadLine());

            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] numOfNotes = new int[8];

            for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    numOfNotes[i] = amount / notes[i];
                    amount = amount - notes[i] * numOfNotes[i];

                    Console.WriteLine("Return notes " +notes[i] + " : " + numOfNotes[i]);
                }
            }
            


        }
    }
}
