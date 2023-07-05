//Name: Punyaja Mishra
//Student Number: 0660001
//This is a program abput calculating average of the salary of the user on a particualar education level. 
/* Variables used are:-
u,U-Character defined by the user to define the education Level UNIVERSITY DEGREE
c,C-Character entered by the user to define the education level COLLEGE DIPLOMA
h,H-Character entered by the user to define the education level HIGH SCHOOL
Salary -> Value entered by the user when telling their individual salary at each education level
averageU-Avereage of all salaries at University Degree
averageC-Average of all salaries at College Diploma
averageH-Average of all salaries at High School
totalsalaryU-The sum of all individual University Degree salaries
totalsalaryC-The sum of all individual College Diploma salaries
totalsalaryH-The sum of all individual High School Salaries
countU-Number of individual salaries entered for University Degree
countC-Number of individual salaries entered for College Diploma
countH-Number of individual salaries entered for High School
EdType-variable to store the education type the user will enter
 */

using System;
public static class Assignment2
{
    public static void Main()
    {
        //Declaring Variables
        char c, C, u, U, q, Q, h, H;
        double Salary;
        double averageU, averageC, averageH;
        double totalsalaryU = 0, totalsalaryC=0, totalsalaryH=0;
        int countU=0, countC=0, countH=0;
        char EdType;

        //Prompting the user to enter his/her education type using do loop and continuing till ser doesn't enter a validate input
        do
        {
            Console.WriteLine("You will have to enter your level of education");
            Console.WriteLine("Enter u/U for University Degrees, c/C for College diplomas and h/H for high school. Enter q/Q for quitting.");
            Console.WriteLine("Now enter the valid education type(or press q/Q to quit):  ");
            EdType = char.ToUpper(Convert.ToChar(Console.ReadLine())); //Converting all input to uppper case for making it easir to write the program code

            //Flashing the error message if character entered is not valid character
            if (EdType != 'U' && EdType != 'C' && EdType != 'H' && EdType != 'Q')
                Console.WriteLine("***Error! Print Valid characters!! ");

            else
            {
                Console.WriteLine("You Entered " + EdType);
            }
        } while (EdType != 'U' && EdType != 'C' && EdType != 'H' && EdType != 'Q');

        //Using whle loop prompt user to enter salary, tell the compiler what to do whem salary is entered and prompt the user again to enter the education level till all data has been inputted
        while (EdType != 'Q')
        {
            //Prompting user to enter salary using do loop
            do
            {
                Console.WriteLine("Enter Your Salary: ");
                Salary = Convert.ToDouble(Console.ReadLine());

                //Making sure value entered is valid, i.e. positive
                if (Salary < 0)
                    Console.WriteLine("***Error!! Salary can't be negtaive. Enter correct Salary ");
                else
                    Console.WriteLine("Salary you entered is {0:C}" ,Salary);

            } while (Salary < 0);

            //Using switch statements to calculate sum (which will be used later to calculate the average) as the salary is being inputted
            switch (EdType)
            {
                case 'U'://university degree
                    countU++;
                    totalsalaryU += Salary;
                    break;
                case 'C'://college diploma
                    countC++;
                    totalsalaryC += Salary;
                    break;
                case 'H': //high school
                    countH++;
                    totalsalaryH += Salary;
                    break;
                default://default case if none of the cases is true
                    Console.WriteLine("***ERROR!! Something is wrong");
                    break;
            }
            
            //Prompting the user to enter another education level if he/she wants and if so, then the loop will continue and again salary input will be asked or else by entering 'q' loop can be exited
            do
            {
                Console.WriteLine("You will have to enter your level of education");
                Console.WriteLine("Enter u/U for University Degrees, c/C for College diplomas and h/H for high school. Enter q/Q for quitting.");
                Console.WriteLine("Now enter the valid education type(or press q/Q to quit):  ");
                EdType = char.ToUpper(Convert.ToChar(Console.ReadLine())); // Converting all input to uppper case for making it easir to write the program code

                //Flashing the error message if character entered is not valid character
                if (EdType != 'U' && EdType != 'C' && EdType != 'H' && EdType != 'Q')
                   Console.WriteLine("***Error! Print Valid characters!! ");

                else
                   Console.WriteLine("You Entered " + EdType);    
            } while (EdType != 'U' && EdType != 'C' && EdType != 'H' && EdType != 'Q');
        }
        //To make sure we don't divide by 0 while calculation of average we use if-else and enter the formula for average calculation for each education type
        
        //For University Degree
        if (countU > 0)
        {
            averageU = totalsalaryU / (double)countU;
        }
        else
            averageU = 0;

        //For College Diploma
        if (countC > 0)
        {
            averageC = totalsalaryC / (double)countC;

        }
        else
            averageC = 0;

        //For High Shool
        if (countH > 0)
        {
            averageH = totalsalaryH / (double)countH;
        }
        else
            averageH = 0;

        //Finally printing the average values
        Console.WriteLine("The average salary at University Education Level is {0:C}, at College Education Level is {1:C} and at High School Level is {2:C}." ,averageU, averageC, averageH);
        Console.ReadLine();
    }
}
