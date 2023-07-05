//Name : Punyaja Mishra
//Student Id : 0660001
//Data Dictionary :
/* NUMERATOR : integer variable which stores the input value of numerator
 * DENOMINATOR : integer variable which stores the input value of denominator
 * testFraction[] : an array of size 5 which is an Object of Fraction 
 * testFraction[0] : object with value 2,1 passed
 * testFraction[1] : object which takes in value from user 
 * testFraction[2] : addition of the previous two
 * testFraction[3] : multiplication of the [0] and [1]
 * Fraction : another class
 */

using System;
public static class FractionDemo
{
    public static void Main()
    {
        //declaring variables to input values
        int inpNum, inpDen;
        //an array is declared as the object of Fraction class 
        Fraction[] testFractions = new Fraction[5];

        //first element of array passes on two parameters(argument 1)
        testFractions[0] = new Fraction(2, 1); //constructor-1
        //second element of array is no parameter
        testFractions[1] = new Fraction(); //constructor-2
        //user is prompted to enter values of numerator and denominator

        Console.WriteLine("Enter the values of numerator and denominator for the fraction");
        //do-while loop to validate value of numerator is positive
        do
        {
            Console.WriteLine("numerator : ");
            //value entered is stored in int variable NUMERATOR
            inpNum = Convert.ToInt32(Console.ReadLine());
            testFractions[1].Numerator = inpNum;//the public property Numerator of Fraction class is given the value entered by the user
        } while (inpNum < 0); //value shouldn't be negative

        //do-while loop to validate the value of denominator is positive and not equal to zero
        do
        {
            Console.WriteLine("denominator : ");
            //value is stored in int variable denominator
            inpDen = Convert.ToInt32(Console.ReadLine());
            testFractions[1].Denominator = inpDen; //public property Denominator of Fraction class is given the value entered
        } while (inpDen <= 0); //value shouldn't be negative

        //printing out the Fractions
        Console.WriteLine("The two Fractions are:");
        Console.WriteLine("Fraction 1 : {0} ", testFractions[0]);
        Console.WriteLine("Fraction 2 : {0} ", testFractions[1]);

        //Overload addition operator
        testFractions[2] = testFractions[0] + testFractions[1];
        //Overload multiplication operator
        testFractions[3] = testFractions[0] * testFractions[1];

        //printing out addition and multiplication of the two fractions.
        Console.WriteLine("Addition of the two fractions : {0} ", testFractions[2]);
        Console.WriteLine("Multiplication of the two fractions : {0} ", testFractions[3]);

        //<= and >= overload operators and printing the result
        if (testFractions[0] <= testFractions[1])
            Console.WriteLine("{0} is less than or equal to {1}",testFractions[0],testFractions[1]);
        else
            Console.WriteLine("{0} is less than or equal to {1}", testFractions[1], testFractions[0]);

        if (testFractions[0] >= testFractions[1])
            Console.WriteLine("{0} is greater than or equal to {1}", testFractions[0], testFractions[1]);
        else
            Console.WriteLine("{0} is greater than or equal to {1}", testFractions[1], testFractions[0]);

        Console.ReadLine();
    }
}
