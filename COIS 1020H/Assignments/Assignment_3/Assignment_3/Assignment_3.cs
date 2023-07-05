//Name: Punyaja Mishra
//Student number: 0660001
//Descrioption: This progrm uses loop, swtich statemnets, methods to create a program to balance a bank account
/*Data Dictionary
 * w,W,d,D,p,P,q,Q : char representing ehther withdrawal, deposit, print or quit.
 * Inout : char to store the character user inputs
 * Amount: double to store the amount to be withdrew or deposited after calling GetAmount method
 * Balance: double indicating the current balance of the account
 * amount: double in Withdrawal() and Deposit() that takes the value of Amount when the method is called
 * balance: ref double in Withdrawal() and Deposit() that tkes the value of Balance when the method is called
 *value: double in GetAmount() that takes up the user,s inputted value when asked amount to be withdrew or depositted and reutyns this value to Amount 
*/

using System;
public static class Assignment_3
{
    public static void Main()
    {
        //Declaring Variables
        char w, W, d, D, p, P, q, Q;
        char Input;
        double Amount;
        double Balance=0;
        
        //main loop in Main() method provoking user to tell what he wants to do and what to do after user inputs
        do
        {
            //provoking user to tell if he wants a withdrawal or deposit or print or just quit
            Console.WriteLine("Enter 'w/W' to withdraw cash, 'd/D' to deposit cash, 'p/P' to print, 'q/Q' to quit:  ");
            Input = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            //What to do after user inputs
            switch (Input)
            {
                //user wants to make a withdrawal
                case 'W': Amount = GetAmount();  //Calling GetAmount() method to validate input by user and returning value to Amount
                          Withdrawal(Amount, ref Balance);  //Calling method Withdrawal() to process if withdrawal possible or not
                          break;

                //user wants to make a deposit    
                case 'D': Amount=GetAmount();   //Calling GetAmount() method to validate input by user and returning value to Amount
                          Deposit(Amount, ref Balance);  //Calling Deposit() method to proces the deposit of money in the account
                          break;

                //user wants his balance printted
                case 'P': Print(Balance);  //Calling of Print() method to print the balance on the screen
                          break;

                //user wants to quit
                case 'Q': Console.WriteLine("Thank You!");  //User quits
                          break;

                //user enters invalid character
                default : Console.WriteLine("***Enter valid character!");  //Telling user his inout was invalid
                          break;


            }
                
        } while (Input != 'Q');  //Loop continues till the user enters Q/q i.e. user wants to quits

        Console.ReadLine();
  
    }

    //GetAmount() method : Method to validate if amount being withdrawn or depostted is positive or not, and if not then flahing error message 
    //Parameters:
    //   value: double storing amount to be withdrew or deposited
    //   Returns: double value to Amount   
    public static double GetAmount()
    {   //Declaring variable to store user input
        double value;

        //Provoking user to enter Value to be withdrew or depositted
        Console.WriteLine("Enter the amount value: ");
        value = Convert.ToDouble(Console.ReadLine());

        //Validating the input is non-negative or not
        if (value < 0)
        {
            Console.WriteLine("***Enter valid amount!");  //If not valid input, telling user his input is wrong
            GetAmount();
        }

        //returning the value to Amount in Main() Method
        return value;
    }   

    //Withdrawal() Method : Method called when user wants to withdraw money and validating if withdrwal possible or not depending if the amount bieing withdrawn is greater than balance or not after applying service charge
    // Parameters:
    //    ServiceCharge: double stroring 1.50, to be added to withdrawing amount
    //    amount: double taking value from variable when method is called and defining amount to be withdrew
    //    balance: ref double indicating balance of account, which should be greater than amount for successful withdrawal
    //    Returns: void
    public static void Withdrawal(double amount, ref double balance)
    {
        //dclaring constant
        double ServiceCharge = 1.50;

        //operation to be performed on amount to be wihdrew, i.e. adding of Service Charge
        amount = amount + ServiceCharge;

        //Validating if amount to be withdrawn is less than avalable balance or not
        if (amount > balance)
            Console.WriteLine("***WITHDRAWAL NOT POSSIBLE. The balance {0:C}, is less than the amount {1:C} (including the service charge), you want to withdraw.", balance, amount);
        else
            balance = balance - amount; //decrease the amount withdrew from the account
        
    }


    //Deposit() Method : Method when user wants to make a deposit of money and validating whether he/she gets 1% bonus if amount is greater than $2000
    //Parameters:
    //    amount: double taking value when method called and indicating the amount to be depositted
    //    balance: ref double indicating the available balance of the account
    //    returns: void
    public static void Deposit(double amount, ref double balance)
    {

        //validating if amount to be depositted is greater than or equal to 2000 or not and so whether or not 1% bonus is recieved by the user
        if (amount >= 2000)
            balance = balance + amount*1.01;  //if the amonunt to be depositted is greater than 2000, he/she recieves a bonus of 1%, so new balance will be balance after deposit plus 1% bonus
        else
            balance = balance + amount;   //if amount being depositted is less than 2000 then no bonus, and amount simply added to the balance

    }

    //Print() method : Method caled when user wants his balance printed on the screen
    //Parameters:
    //   balance: double indicating current balance of the user
    //returns: void
    public static void Print(double balance)
    {
        Console.WriteLine("{0:C} is your current balance", balance);   //printing the current balance in the account
    }
}