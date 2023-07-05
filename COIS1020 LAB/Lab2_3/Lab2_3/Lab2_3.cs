// Name: xxxxxxxxxxxxx
// Student Number: xxxxxxx
// Lab 2, Part 3
// Program Description: This program uses a loop and if statement to input marks
//    between 0 and 100) from a user, determines if the mark is pass or fail
//    and outputs the percentage of passing and failing marks. The user then 
//    terminates the program by entering a negative value for a mark.

using System;
public static class Lab2_3
{
    public static void Main()
    {
        const int PASS = 50;
        int numPass = 0, numFail = 0, totalMarks = 0 ;
        double mark, perPass = 0, perFail = 0, sumfail = 0,avgfail=0;



        // loop to read in a valid mark or the sentinel value
        do
        {
            // Read initial mark (seed the loop)
            Console.Write("Enter a mark between 0 and 100 (-ve value to stop): ");
            mark = Convert.ToDouble(Console.ReadLine());
        } while (mark > 100);
        // if the inputted mark is not the sentinel value, process it

        while (mark >= 0 && mark <= 100)
        {

            // increment the counter for the total number of data values
            // *** Insert code
            totalMarks++;

            // Determine if the mark is a pass or fail (If statement)
            // *** Insert code
            if (mark > PASS)
                numPass++;
            else
            {
                sumfail += mark;
                numFail++;
            }

            // Read next mark
            // *** Insert code
            do
            {
                // Read initial mark (seed the loop)
                Console.Write("Enter a mark between 0 and 100 (-ve value to stop): ");
                mark = Convert.ToDouble(Console.ReadLine());
            } while (mark > 100);
        }

        // Calculate the percentage of marks that were passes and fails
        // *** Insert code
        if (totalMarks > 0)
        {
            perPass = (numPass * 1.00 / totalMarks);
            perFail = (numFail * 1.00 / totalMarks);
            avgfail = (sumfail * 1.00 / numFail);
        }
        else
        {    perFail = 0;
             perPass = 0;
        }

        // Print results
        Console.WriteLine("Total number of marks = {0}", totalMarks);
        Console.WriteLine("Percentage of passing marks = {0:P1}", perPass);
        Console.WriteLine("Percentage of failing marks = {0:P1}", perFail);
        Console.WriteLine("Average of failing marks = {0}", sumfail);
        Console.ReadLine();
    }
}
