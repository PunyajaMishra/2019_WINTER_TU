// Name: Punyaja Mishra
// Student Number: 0660001
// Lab 3, Part 2
// Program Description: This program uses two user defined methods to compute 
//    the gross pay and net pay for an employee after entering the employee’s
//    last name, hours worked, hourly rate, and percentage of tax.

using System;
public static class Lab3_2
{
    public static void Main()
    {
        // declare variables
        int hrsWrked;
        double ratePay, OTPay, taxRate, grossPay, netPay = 0;
        string lastName;

        // enter the employee's last name
        Console.Write("Enter the last name of the employee => ");
        lastName = Console.ReadLine();

        // enter (and validate) the number of hours worked (positive number)
        do
        {
            Console.Write("Enter the number of hours worked (> 0) => ");
            hrsWrked = Convert.ToInt32(Console.ReadLine());
        } while (hrsWrked < 0);

        // enter (and validate) the hourly rate of pay (positive number)
        // *** Insert the code to enter and validate the ratePay
        do
        {
            Console.Write("Enter the hourly pay rate(>0)=>  ");
            ratePay = Convert.ToDouble(Console.ReadLine());
        } while (ratePay < 0);

        // enter (and validate) the percentage of tax (between 0 and 1)
        // *** Insert the code to enter and validate taxRate 
        do
        {
            Console.Write("Enter percent of tax(between 0 and 1)=> ");
            taxRate = Convert.ToDouble(Console.ReadLine());

        } while (taxRate < 0 || taxRate > 1);

        // Call a method to calculate the gross pay (call by value)
        grossPay = CalculateGross(hrsWrked, ratePay);

       
        
        //Call a method to calculate overtime(call by value)
        OTPay = CalculateOT(hrsWrked, ratePay);


        grossPay = grossPay + OTPay;

        // Invoke a method to calculate the net pay (call by reference)
        CalculateNet(grossPay, taxRate, ref netPay);


        // print out the results
        Console.WriteLine("{0} worked {1} hours at {2:C} per hour", lastName,
                          hrsWrked, ratePay);
        // *** Insert the code to print out the Gross Pay and Net Pay
        Console.WriteLine("The gross pay of employee {0} is {1:C} with {3:C} overtime pay and the net pay of {0} is {2:C}", lastName, grossPay, netPay,OTPay);


        // Call a method to calculate the gross pay (call by value)
        grossPay = CalculateGross(hrsWrked, ratePay);



        //Call a method to calculate overtime(call by value)
        OTPay = CalculateOT(hrsWrked, ratePay, 2);


        grossPay = grossPay + OTPay;

        // Invoke a method to calculate the net pay (call by reference)
        CalculateNet(grossPay, taxRate, ref netPay);


        // print out the results
        Console.WriteLine("{0} worked {1} hours at {2:C} per hour", lastName,
                          hrsWrked, ratePay);
        // *** Insert the code to print out the Gross Pay and Net Pay
        Console.WriteLine("The gross pay of employee {0} is {1:C} with {3:C} overtime pay and the net pay of {0} is {2:C}", lastName, grossPay, netPay, OTPay);


        Console.ReadLine();
    }

    // Method: CalculateGross
    // Parameters
    //      hours: integer storing the number of hours of work
    //      rate: double storing the hourly rate
    // Returns: double storing the computed gross pay
    public static double CalculateGross(int hours, double rate)
    {
        // *** Insert the contents of the CalculateGross Method
        double grossPay1 = 0;
        grossPay1 = hours * rate;
        return grossPay1;
    }
    
    //Method:CalculateOT
    /*Parameters:
       hours:integer storing hours at work
       rate:double storing the houly rate
       Extra: optional, The multiplier rate for overtime pay
       OTpay:double storing the overtime pay
       */
    //Returns:double storing the overtime pay

        public static double CalculateOT(int hours,double rate, double Extra=1.5)
    {
        double OTpay;
        if (hours > 40)
        {
            OTpay = (hours - 40) * rate * (Extra-1.0);
        }
        else
            OTpay = 0;

        return OTpay;
    }

    // Method: CalculateNet
    // Parameters
    //      grossP: double storing the grossPay
    //      tax: double storing tax percentage to be removed from gross pay
    //      netP: call by reference double storing the computed net pay
    // Returns: void 
    public static void CalculateNet(double grossP, double tax, ref double netP)
    {
        // *** Insert the details of the CalculateNet Method
        netP = grossP - (grossP * tax);

    }
}
