using System;
using System.Collections.Generic;
using System.Text;

namespace BlairConsoleAppsHW1
{
    public class TakeUserInput
    {
	    public static int GetPriceInDollars()
	    {
		   Console.WriteLine("Enter the price in dollars");
		   int priceinDollarsAsCents = Convert.ToInt32(Console.ReadLine()) * 100;
		   return priceinDollarsAsCents;
	    }

	    public static int GetPriceInCents()
	    {
		    Console.WriteLine("Enter price in cents: ");
		    int priceInCents = Convert.ToInt32(Console.ReadLine());
		    return priceInCents;
	    }

	    public static int GetDollarsReceived()
	    {
		    Console.WriteLine("Enter money received in dollars: ");
		    int receivedDollarsAsCents = Convert.ToInt32(Console.ReadLine()) * 100;
		    return receivedDollarsAsCents;
	    }

	    public static int GetCentsReceived()
	    {
		    Console.WriteLine("Enter money received in cents: ");
		    int receivedCents = Convert.ToInt32(Console.ReadLine());
		    return receivedCents;
	    }
    }
}
