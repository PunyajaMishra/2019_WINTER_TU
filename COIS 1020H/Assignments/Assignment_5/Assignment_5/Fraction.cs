//Name : Punyaja Mishra
//Student Id : 0660001
//Data Dictionary :
/* numerator : private field that denotes the numerator of the fraction
 * denominator : private field that denotes the denominator of the fraction
 *  Numerator : public property
 * Denominator : public property
 * + : overloading additon operator
 * * : overloading multiplication operator
 * <= : overloading less than or equal to operator
 * >= : overloading greater than or equal to operator
 */

using System;
public class Fraction //Fraction class
{
    //private fields in Fraction class
    private int numerator;
    private int denominator;

    //no argument constructor, constructor-1
    public Fraction()
    {
        numerator = 0;
        denominator = 1;       
    }

    //constructor-2 taking in two arguments
    public Fraction(int num, int den)
    {
        Reduce(ref num, ref den); //calling Reduce Method and passing values by reference
        numerator = num;
        denominator = den;
    }

    public int Numerator //property Numerator
    {
        //setting the value of the numerator entered by the user
        set
        {
            //validating, the value entered by user must be positive
            if (value >= 0)
                numerator = value;
            else
                numerator = 1;
            
        }
        
    }

    public int Denominator //property denominator
    {
        //setting the value of the denominator entered by the user
        set
        {
            //validating, the value entered by user must be positive
            if (value > 0)
                denominator = value;
            else
                denominator = 1;
            Reduce(ref numerator, ref denominator); //calling Reduce() Method once both Numerator and Denominator values have been entered by the user
        }
         
    }

    //Method : Reduce Method takes two arguments by reference
    //returns : void
    //num, den : int reference variables storing the values of numerator and denominator
    private void Reduce(ref int num, ref int den)
    { 
        //finding the greatest common divisor if numerator is larger
        if (num > den)
        {
            int k = num;
            int m = den;
            
            while(m>0)
            {
                int remainder = k % m;
                k = m;
                m = remainder;
            }

            num = num / k;
            den = den / k;

        }
        else
        //finding the greatest common divisor if denominator is larger
        {
            int k = den;
            int m = num;
            
            while (m > 0)
            {
                int remainder = k % m;
                k = m;
                m = remainder;
            }

            num = num / k;
            den = den / k;
        }

       

    }

    // ToString() Method to print out the fractions
    public override string ToString()
    {
        return numerator + "/" + denominator;
    }

    //Overloading Multiplication Operator
    public static Fraction operator *(Fraction f1, Fraction f2)
    {
        //takes the two Fraction objects and used to find value after their multiplication
        int num;
        int den;

        num = f1.numerator * f2.numerator;
        den = f1.denominator * f2.denominator;

        //a new object made and given values after multiplication
        Fraction f3 = new Fraction(num, den);
        return f3; //value returned

    }

    //Overloading Addition Operator
    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        //takes the two Fraction objects and used to find value after their addition and the reutning the value 
        return new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
    }

    //Overloading less than or equal to Operator using boolean
    public static bool operator <=(Fraction f1, Fraction f2)
    {
        //finding double values of fractions for easy comparision
        double value1 = f1.numerator / (double)f1.denominator;
        double value2 = f2.numerator / (double)f2.denominator;


        if (value1 <= value2)
        {

            return true;
        }

        else
            return false;
    }

    //Overloading greater than or equal to Operator using boolean
    public static bool operator >=(Fraction f1, Fraction f2)
    {
        //finding double values of fractions for easy comparision
        double value1 = f1.numerator / (double)f1.denominator;
        double value2 = f2.numerator / (double)f2.denominator;

        if (value1 >= value2)
            return true;
        else
            return false;

    }


}