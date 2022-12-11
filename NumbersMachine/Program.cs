using Microsoft.Extensions.Logging;
using NumberProcessor;
using System;

namespace NumbersMachine
{
	internal class Program
	{
		private readonly ILogger _logger;//logging will be added
		//unit tests will be added
		static void Main(string[] args)
		{

     		Console.WriteLine("Hello, welcome to Number Machine. You can now enter the number!");

			Number numberObj = new Number();
			bool success = false;
			do
			{
				try
				{
					int numberEnttered = Convert.ToInt32(Console.ReadLine());
					NumberProcessor.NumberProcessor np = new NumberProcessor.NumberProcessor();
					Console.WriteLine(np.ProcessAndWriteToFile(numberEnttered));
					success = true;
					Console.WriteLine("Processing is done, above result is appended to file named as:" + Globals.FileName()+", Now you can press any key to exit. Thank you for using our Processing machine.");
					Console.ReadKey();
					Environment.Exit(0);
				}
				catch (Exception e)
				{
					Console.WriteLine("Your enterred number has some issue, please try again!");
				}
			}
			while (success==true);
		}
	}
}
