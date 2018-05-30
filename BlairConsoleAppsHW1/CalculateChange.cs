using System;
using System.Collections.Generic;
using System.Text;

namespace BlairConsoleAppsHW1
{
    public static class CalculateChange
    {
	    public static void MakeChange(int priceinDollarsAsCents, int priceInCents, int recievedDollarsAsCents, int receivedCents)
	    {
		    int totalRecieved = receivedCents + recievedDollarsAsCents;
		    int totalPrice = priceInCents + priceinDollarsAsCents;
		    int changeToReturn = totalRecieved - totalPrice;

		    if (totalRecieved > totalPrice)
		    {
				CalculateChangeNeeded(changeToReturn);
		    }

		    else if (totalRecieved == totalPrice)
		    {
			    NoChangeNeeded();
		    }

		    else
		    {
				MoneyStillOwed(totalPrice, totalRecieved);
		    }
		}

	    private static void CalculateChangeNeeded(int changeToReturn)
	    {
			int dollarstoReturn = changeToReturn / 100;
		    int centsRemainingAfterDollars = changeToReturn % 100;
		    int centsRemaining = centsRemainingAfterDollars;

		    int quartersToReturn = centsRemaining / 25;
		    centsRemaining = centsRemaining % 25;

		    int dimesToReturn = centsRemaining / 10;
		    centsRemaining = centsRemaining % 10;

		    int nickelsToReturn = centsRemaining / 5;
		    int penniesToReturn = centsRemaining % 5;

		    Console.WriteLine($"Your change is {dollarstoReturn} dollar(s) and {centsRemainingAfterDollars} cents. ");
		    Console.WriteLine("Dollars: " + dollarstoReturn);
		    Console.WriteLine("Quarters: " + quartersToReturn);
		    Console.WriteLine("Dimes: " + dimesToReturn);
		    Console.WriteLine("Nickels: " + nickelsToReturn);
		    Console.WriteLine("Pennies: " + penniesToReturn);
		}

	    private static void NoChangeNeeded()
	    {
			Console.WriteLine("No change for you.");
		}

		private static void MoneyStillOwed(int totalPrice, int totalRecieved)
		{
			int amountOwed = totalPrice - totalRecieved;
			int dollarsOwed = amountOwed / 100;
			int centsOwed = amountOwed % 100;
			Console.WriteLine($"You still owe {amountOwed} cents, AKA {dollarsOwed} dollar(s) and {centsOwed} cents");
		}
	}
}
