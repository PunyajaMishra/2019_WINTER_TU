//Name: Punyaja Mishra
//StudentId: 0660001
//Program description: The program helps a user either book, cancel or print tickets in a plane in Air Canada airlines
/*Data Dictionary:
 * b,B,c,C,p,P,q,Q : char representing booking seat, cancelling a seat, printig seats, and quitting
 * inp : variable to store the input character the user enters 
 * seat : an array of type string and size 10 which stores the seats of an airplane
*/


using System;
public static class Assignment_4
{
    public static void Main()
    {
        //defining variables
        char b, B, c, C, p, P, q, Q;
        char inp;
        string[] seat = new string[10] { "","","","","","","","","",""};     //string array that define seats in the airplane

        //do-while loop prompting user to enter the characters whether they want to book a seat or cancel a seat or print out all the seats or quit and then call out the required method
        do
        {
            //Prompting the user to enter character
            Console.WriteLine("Welcome to Air Canada");
            Console.WriteLine("Enter what you want to do, (b/B) to book a seat, (c/C) to cancel a seat. (p/P) to print seating arrangement or (q/Q) to quit ");
            inp = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            //switch statement to call the required methods based on the character entered by the user that was stored in a char variable inp
            switch (inp)
            {
                case 'B':
                    Booking(seat);  //calling Booking() Method to book seats as the character chosen was 'B/b'
                    break;

                case 'C':
                    Cancel(seat);   //calling Cancel() method to cancel a seat because character chosen was 'C/c'
                    break;

                case 'P':
                    PrintSeat(seat);    //calling PrintSeat() method to print out the seating arrangement as the character chosen was 'P/p'
                    break;

                case 'Q': Console.WriteLine("Thank You!! ");
                          break;    //user chooses to quit

                default:
                    Console.WriteLine("*** Invalid character");     //if any other character other than 'B/b', 'C/c', 'P/p', 'Q/q' is entered, it is invalid, and so an error message should be printed
                    break;

            }


        } while (inp != 'Q');   //the do-while loop should continue till user chooses to quit

        Console.ReadLine();
        
    }

    //FindEmptySeat() Method : Method that takes the seat array and returns Empty Seat
    //Parameters:
    //      i = integer used as a variable in the for loop used as index in the array
    //      seat = integer variable that is given the value of i if any index in the array is empty and -1 if no seat is empty
    //      found = boolean value which is true if an empty seat is available
    //      SeatAssign = array of type string which takes the seat array declared in main()
    // Returns: integer = array index with null or -1 if all indices in the array are filled
    public static int FindEmptySeat(string[] SeatAssign)
    {
        //declaring local variables in this Method
        int i=0, seat=0;
        bool found = false; //boolean variable to be true when a seat with null is found

        //while loop to traverse through a loop to find an index with null in the array till boolean turns true OR the array length is completed
        while (i<SeatAssign.Length && !found)
        {
            if (SeatAssign[i] == "")
            {
                found = true;   //if null is found in array then boolean variable is changed to true
                seat = i;       //and seat is assigned the value of the index where there is null
            }

            else
                seat = -1;      //if no position in array is unoccupied then seat is assigned -1

            ++i;
        }

        return seat;        //the integer value of seat is returned back
    }

    //FindCustomerSeat() Method : Method that takes in the array and returns the seat that has been cancelled
    //Parameters :
    //      found = boolean value which turns true when the customer wanting to cancel his seat is found
    //      i = integer used to define array index
    //      seat = integer which stores the value of i (the array index) when customer name is found
    //      SeatAssign = array of type string which takes the seat array declared in main()
    //      cName = string that takes the customer name that the user entered in the Method that calls this method 
    //returns : integer = seat, the array index where name has been canceled or -1 if no seat under the name found
    public static int FindCustomerSeat(string[] SeatAssign, string cName)
    {
        //declaring local variables in this Method
        bool found = false;     //boolean variable to be true when a seat with customer name is found
        int i = 0, seat=0;

        //while loop to traverse through a loop to find an index with the customer name in the array till boolean turns true OR the array length is completed
        while (i<SeatAssign.Length && !found)
        {
            if (SeatAssign[i] == cName)
            {
                found = true;       //if customer name is found in array then boolean variable is changed to true
                seat = i;       //and seat is assigned the value of the index where there is the customer name

            }

            else
                seat = -1;      //if no position in array has the customer name then seat is assigned -1

            ++i;
        }

        return seat;        // theinteger value of seat is returned back
    }

    //Booking() Method : Method that takes up the seat array 
    //Parameters :
    //      x = integer variable which takes the integer value returned by FindEmptySeat() Method
    //      name = the string that stores the customer name on prompting the user to enter
    //      NAME = the string that stores the name of the user in uppercase
    //      SeatAssign = array of type string which takes the seat array declared in main()
    //returns : void
    public static void Booking(string[] SeatAssign)
    {
        //declaring local variables in this Method
        int x;
        string name;
        

        //user is prompted to enter his name
        
        
            Console.WriteLine("Hello! Enter your name: ");
            name = Convert.ToString(Console.ReadLine());

        if (FindCustomerSeat(SeatAssign, name) == -1)
        {


            x = FindEmptySeat(SeatAssign);     //FindEmptySeat() method is called and the integer value of seat returned is stored in x

            if (x != -1 && x > -1 && x < 10)
            {
                SeatAssign[x] = name;
                Console.WriteLine("Seat {0} : {1}", x, name);
            }
            else
                Console.WriteLine("{0}, sorry, no seat available, the plane is Full!", name);
        }
        else
        {
            Console.WriteLine("Sorry, a seat ia already booked under this name.");

            Booking(SeatAssign);
        }

    }

    //Cancel() Method : Method that is called when the user wants to cancel his seat 
    //Parameters : 
    //      y = integer variable to store the integer value returned from the FindCustomerSeat() Method
    //      name = string to store the customer name when prompted to enter his/her name
    //      NAME = string to store the user's name in uppercase
    //      SeatAssign = array of type string which takes the seat array declared in main()
    //returns : void
    public static void Cancel(string[] SeatAssign)
    {
        //user is prompted to enter his name
        int y;
        string name;
        
        //user is prompted to enter his name
        Console.WriteLine("Enter your name: ");
        name = Convert.ToString(Console.ReadLine());
        

        y = FindCustomerSeat(SeatAssign, name);     //FindCustomerSeat() method is called and the integer value of seat returned is stored in y

        if (y != -1)        //if the value returned by the method is not -1 then the seat is cancelled
        {
            SeatAssign[y] = "";     //To cancel the seat the new value stored is null again in the position where there was the name of the customer
            Console.WriteLine("Seat {0} Cancelled",y);      //A message is flashed on the screen that the seat has been cancelled
        }

        else
            Console.WriteLine("No one with name {0} has a seat in the plane", name);    //if the value returned is -1, that means the customer name was not found and the same is flashed in a message to the user

    }

    //PrintSeat() Method : Method called to print all the seats in the airplane
    //Parameters : 
    //      SeatAssign = array of type string that takes the seat array defined in the Main() Method
    //      i = integer variable used in loop to define the index in an array
    //returns : void
    public static void PrintSeat(string[] SeatAssign)
    {
        //loop to traverse through the entire array
        for (int i = 0; i < SeatAssign.Length; ++i)     
            Console.WriteLine("Seat {0} : {1} ",i,SeatAssign[i]);       //as the compiler traverses through the array the value stored in the array is printed out
    }





}