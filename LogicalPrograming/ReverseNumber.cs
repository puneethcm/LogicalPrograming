using System;
namespace LogicalPrograming
{
	public class ReverseNumber
	{
		public static void FindReverseNumber()
		{
			int remainder = 0, reverse = 0;
			Console.WriteLine("\nEnter the number to be Reversed");
			int number = Convert.ToInt32(Console.ReadLine());
			while (number != 0)
			{
				remainder = number % 10;
				reverse = (reverse * 10) + remainder;
				number = number / 10;
			}
			Console.WriteLine("\nReverse number: " + reverse);
		}
	}
}

