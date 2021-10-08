using System;
using static System.Console;

namespace CSC240_02_01_ArrayDemo1_bpc1
{
    class ArrayDemo1
    {
        static void Main(string[] args)
        {
            // STORAGE
            double[] payRate = { 13.00, 17.35, 19.12, 22.45 };

            // INPUT

            // PROCESS
            for(int x = 0; x < payRate.Length; ++x)
            {
                WriteLine("Pay rate {0} is {1}", x+1, payRate[x].ToString("C"));
            }

            // OUTPUT
            ReadLine();
        }
    }
}
