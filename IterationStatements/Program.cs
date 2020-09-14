/* 
 Author: Franchesca Guerra
 Date: 9/15/2020
 Comment: This C# Console application code demonstrate the use of
            iterative statements after getting input from users.
*/


using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ask the user for input
           
            
         Console.WriteLine("Enter an Integer value between 1 and 25 to execute and iterative statement: ");
           try
            {
                //This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perfrom varous iterative statemnts and is praised as an integer 
                int value_of_input = int.Parse(input);

                // if the value of user input is between 1 and 25, execute a While Loop
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a While Loop!");
                    Console.WriteLine("The While Loop will iterate" + value_of_input.ToString() + " times");
                    // Here ir the for loop
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("you have entered "  +  input.ToString() + " This is the current integer value in loop " + value_of_input.ToString());
                        value_of_input--;
                    }
                    Console.WriteLine("Press any key to exit the program");
                    //pause the program and wait the user to press a key to end the program
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an iteger between 1 and 25 and try again");
                    Console.WriteLine("Press key to exit the program and try again...");
                    Console.ReadKey(true);
                }


            }// end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again");
                Console.WriteLine("Please eneter any key to exit the program...");
                Console.ReadKey(true);
            }// end of catch


        }





        


    }
}
