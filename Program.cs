using System;
using System.Threading.Tasks;
using static DiceSimulatorC_.Results;

namespace DiceSimulatorC_;

internal class Program
{
    private static void Main(string[] args)
    {
        Results result = new Results();

        int NumRolls = 0;
        string NumRollsString = "";
        double[] daRollResults = new double[NumRolls];

        Console.WriteLine("Welcome to the dice throwing simulator!");

        //Ask user how many times they want ot roll the dice
        Console.Write("Enter the number of times you want me to roll these two dice: ");
        NumRollsString = Console.ReadLine();

        //Converting the string received to an Integer 
        NumRolls = Convert.ToInt32(NumRollsString);

        //Printing out a string to show the user how many times the dice will be rolled
        Console.WriteLine("For you, my fine feathered friend, I will roll these two dice " + NumRolls + " times!"); Console.WriteLine();
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls."); Console.WriteLine();

        //Send the number of rolls to the other class and place the response into "daRollResults"
        daRollResults = result.RollDemDice(NumRolls);


        //While loop to run through the whole array. uCount starts at 2 so it starts at where rolls of "2" are stored
        int uCount = 2;        
        while (uCount < 13)
        {
            //Calculate Percentage
            double dPercent = 0.0;
            dPercent = (daRollResults[uCount] / NumRolls) * 100 ;

            //Starting line to print
            Console.Write(uCount + ": ");

            //Print the correct number of astericks 
            for (int vCount = 0; vCount < dPercent; vCount++) 
            {
                Console.Write("*");
            }
            //New line.
            Console.WriteLine();
            uCount++;
        }
        

    }
}
/* 
 Console.WriteLine("Two was rolled " + daRollResults[3] + " times");

 
 */