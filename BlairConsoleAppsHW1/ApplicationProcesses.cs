using System;
using System.Collections.Generic;
using System.Text;

namespace BlairConsoleAppsHW1
{
    public class ApplicationProcesses
    {
	    public static void RunApplication()
	    {
			int priceinDollarsAsCents = TakeUserInput.GetPriceInDollars();
		    int priceInCents = TakeUserInput.GetPriceInCents();
		    int recievedDollarsAsCents = TakeUserInput.GetDollarsReceived();
		    int receivedCents = TakeUserInput.GetCentsReceived();

		    CalculateChange.MakeChange(priceinDollarsAsCents, priceInCents, recievedDollarsAsCents, receivedCents);
			EscapeProgram();
		}

	    private static void EscapeProgram()
	    {
			Console.WriteLine("Press 'Y' to continue or any other key to exit.");
			char userResponse = Console.ReadKey().KeyChar;

		    if (userResponse.Equals('Y') || userResponse.Equals('y'))
		    {
			    RunApplication();
		    }
		}
    }
}
