//Lauri Rämö
using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace Hello
{ 

 public class BlackJack
{
    public static void Blacks()
    {
        int myNumber = 17;
        int theirNumber;
        System.Console.WriteLine("*** BlackJack! ***");
        do //infinite game times
        {
            do //If number is not between 1-21 program asks number again
            {
                    System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting 
            
            
                theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
            //comparing that given umber is valid
            

            
        if (theirNumber < 1 || theirNumber > 21)
        {
           Console.WriteLine("The given number is out of limits, try again.");
        }
            
        else
        {
            //comparing
            if (theirNumber >= myNumber && theirNumber <= 21)
            {
                System.Console.WriteLine("You win.");
            }
            else
            {
                System.Console.WriteLine("You lose.");
            }
                
        }
        } while (theirNumber < 1 || theirNumber > 21);
        } while (true);
        }
}
}
