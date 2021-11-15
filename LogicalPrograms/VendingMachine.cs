using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        int[] arr = new int[8];
        public void Machine(int amount)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (amount >= notes[i])
                {
                    arr[i] = amount / notes[i];
                    amount = amount - (arr[i] * notes[i]);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + arr[i]);
                }
            }
        }
    }
}

