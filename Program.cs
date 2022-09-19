/*  
 Purpose:Write a program for an Internet service provider so they can calculate how much to bill their
customers. The provider offers customers 3 packages:
PACKAGE COST CALCULATION
A $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
C $19.95 per month for unlimited hours
The program should prompt for the letter of the service package (A, B, or C) and the number of
hours they have used if either option A or B has been selected.

Input: package, hours
Output: bill
 Author: Ilyas G
Date: Sept 19 2022
 */
using System.Xml;

namespace providercost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            char package;
            int hours = 0;
            double total;

            // inputs
            // a menu
            Console.WriteLine("Select the service package from the options below:");
            Console.WriteLine("\tA - $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour"); // \t tabs line
            Console.WriteLine("\tB - $13.95 per mnth for up to 20 hours; additional hours are billed at $1.00 per hour ");
            Console.WriteLine("\tC - $19.95 per month for unlimited hours");
            Console.Write("Option: "); 
            package = char.Parse(Console.ReadLine().ToUpper()); // input from a keyboard is always a string, always parse the input from the keyboard, also gets input from keyboard
                                                      // and even if it is a lower it will use .toupper() to convert it to a uppercase letter

            // prompt for hours if A or B selected
              if (package == 'A' || package == 'B' )
               {
                   Console.Write("Enter hours used: ");
                   hours = int.Parse(Console.ReadLine());
               }
/*
               // calculate bill
               if (package == 'A' )
               {
                   total = 9.95;
                   if (hours > 10)
                   {
                       total += (hours - 10) * 2; 
                   } 
               }
               else if(package == 'B' )
               {
                   total = 13.95;
                   if (hours > 20)
                   {
                       total += (hours - 20);// total = total + (hours - 20) 
                   }
               }
               else
               {
                   total = 19.95;
               }
            */
            // switch logic
           switch (package)
            {
                case 'A':
                total = 9.95;
                    if (hours > 10)
                    {
                        total += (hours - 10) * 2;
                    }
                    break;
                case 'B':
            
                    total = 13.95;
                    if (hours > 20)
                    {
                        total += (hours - 20);// total = total + (hours - 20) 
                    }
                    break;
                case 'C':
                  total = 19.95;
                    break;
                default:
                    total = 0;
                    Console.WriteLine("Invalid selection");
                    break; // have to put a break at end of a switch to get out of the switch

            

        }







            // display results
            Console.WriteLine($"The bill is ${total}");
                Console.ReadLine();
        }
    }
}