using System;/*Steven Shetler, The purpose of this application is to randomly simulate
* the rolling of a pair of dice 36,000 times and then display the results of the simulation
* in a table showing the sum, frequency, and percentage of the simulation. Each running of the program will produce new results.*/

public class DiceRoll
{
    public static void Random()
    {
        Random rd1367 = new Random();//object creation expression
        //creating the dice
        int die1;
        int die2;
        int[] rolls = new int[13];//array creation expression, length is 12, we will ignore 0 and 1 since we cannot get a sum of 0 or 1

        for (int roll = 1; roll <= 36000; roll++)//for loop that is simulating the rolling of dice 36,000 times
        {
            die1 = rd1367.Next(1, 7);//1 through 6, 7 is excluded
            die2 = rd1367.Next(1, 7);//1 through 6, 7 is excluded
            ++rolls[die1 + die2];//adding the two die rolls together to get the sum
        }

        Console.WriteLine("{0,8}{1,12}{2,12}", "Sum", "Frequency", "Percentage");//creating header for our tabular printout

        for (int i = 2; i <= 12; i++)//for loop that will find the percent of each sum
        {
            double percent = rolls[i] / (360.0);//percent calculation, dividing by 360 will give us 100% total
            Console.WriteLine("{0,8}{1,12}{2,12:F}", i, rolls[i], percent);//printing results of the random dice roll: i is the sum, rolls[i] is the frequency, and percent is the percentage of each sum
        }
    }
}