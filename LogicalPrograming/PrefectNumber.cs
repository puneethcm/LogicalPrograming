using System;
namespace LogicalPrograming
{
	public class PrefectNumber
	{
		public static void FindPrefectNumber()
		{
			int sum = 0;
			Console.WriteLine("\nEnter the Number");
			int number = Convert.ToInt32(Console.ReadLine());
			for(int i = 1; i < number; i++)
			{
				if (number % i == 0)
				{
					sum = sum + i;
				}
			}
			if (number == sum)
				Console.WriteLine("Its Prefect number");
			else
				Console.WriteLine("Its Not a Prefect number");
		}
	}
}

