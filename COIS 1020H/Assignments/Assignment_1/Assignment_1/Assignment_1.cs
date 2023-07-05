using System;
public static class Assignment_1
{
    public static void Main()
    {
        const double SurCharge = 0.25D;
        const double Tax = 1.13D;
        int NumOfDonuts;
        double CostPerDonut=0, Cost;
        string Name;

        Console.Write("Welcome to 'Jimmy Donut Store'! ");
        Console.ReadLine();

        Console.WriteLine("It's never too late to have Jimmy's infamous DONUTS!");
        Console.ReadLine();

        Console.WriteLine("Enter your name=> ");
        Name=Console.ReadLine();

        Console.WriteLine("Enter the number of donuts you wish to purchase=> ");
         NumOfDonuts = Convert.ToInt32(Console.ReadLine());

        if (NumOfDonuts < 0)
            Console.WriteLine("***ERROR! Number of donuts cannot be negative, not yet at 4least, Jimmy is still working on that.");
        else if (NumOfDonuts >= 0 && NumOfDonuts <= 7)
            CostPerDonut = 1.00;
        else if (NumOfDonuts > 7 && NumOfDonuts < 15)
            CostPerDonut = 0.90;
        else
            CostPerDonut = 0.75;


        if (NumOfDonuts < 0)
        {
            Cost = 0;
            Console.WriteLine("You ordered {0} Donuts and you have to pay ${1:F2}", NumOfDonuts, Cost);
            Console.ReadLine();
            Main();
        }
        else if(NumOfDonuts==0)
        {   Cost = 0;
            Console.WriteLine("You ordered {0} Donuts and you have to pay ${1:F2}", NumOfDonuts, Cost);
            Console.ReadLine();
        }
        else if (NumOfDonuts > 0 && NumOfDonuts < 12)
        {
            Cost = ((NumOfDonuts * CostPerDonut) + SurCharge) * Tax;
            Console.WriteLine("You ordered {0} Donuts and you have to pay ${1:F2}", NumOfDonuts, Cost);
            Console.ReadLine();
        }
        else
        {
            Cost = ((NumOfDonuts * CostPerDonut) + SurCharge);
            Console.WriteLine("You ordered {0} Donuts and you have to pay ${1:F2}", NumOfDonuts, Cost);
            Console.ReadLine();
        }



        }
}