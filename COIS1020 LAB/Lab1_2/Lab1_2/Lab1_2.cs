using System;
public static class Lab1_2
{
    public static void Main()
    {
        int idNum;
        double payRate, grossPay, netPay, hours, taxRate;
        string firstName, lastName;

        Console.Write("Enter employee's first name =>");
        firstName = Console.ReadLine();

        Console.Write("Enter employee's last name=>");
        lastName = Console.ReadLine();

        Console.Write("Enter employee's six-digit id Number=>");
        idNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of hours employee worked => ");
        hours = Convert.ToDouble(Console.ReadLine());        Console.Write("Enter employee's hourly pay rate: ");
        payRate = Convert.ToDouble(Console.ReadLine());        Console.Write("Enter the tax rate percentage => ");        taxRate = Convert.ToDouble(Console.ReadLine());        grossPay = hours * payRate;        netPay = grossPay * ((100 - taxRate) / 100);        Console.WriteLine("Employee {0} {1}, (ID: {2}) earned {3:C} and net pay is {4:C}", firstName, lastName, idNum, grossPay, netPay);        Console.ReadLine();

    }
}
