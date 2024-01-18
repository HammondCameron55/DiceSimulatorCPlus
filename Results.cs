using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulatorC_
{
    internal class Results

    {
        //make method 
        public double[] RollDemDice(int numRoll)
        {
            //Receive num rolls from main program
            int RollNumber = numRoll;
            int iCount = 0;
            double[] rollTotals = new double[13];
            Random random = new Random();

            //While loop
            while (iCount < numRoll) 
            {
                int idie1 = 0;
                int idie2 = 0;
                int irollValue = 0;
                               

                idie1 = random.Next(1, 7);
                idie2 = random.Next(1, 7);
                irollValue = idie1 + idie2 ;



                rollTotals[irollValue]++;

                iCount++;
             }

            return rollTotals; 

            // rolls are done
            
        }
    }
}



//Division in C#
/*
 integers don't have decimals 
Just make one of them a Double 
OR
keep them as integars and do this:
    int num1 = 13
    int num2 = 100

    13 * 100 / 1000
 */