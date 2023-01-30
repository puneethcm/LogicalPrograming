using System;
namespace LogicalPrograming
{
	public class Fibonacci
	{
		public static void FindFibonacciNumber()
		{
            Console.WriteLine("\nEnter the number to find Fibonacci numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3, i;
            Console.Write("\nFibonacci Numbers are: ");
            Console.Write(n1 + "" + n2 + "");

            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + "");
                    //initializing n1 value to n2
                n1 = n2;
                n2 = n3;
            }
        }
	}
}

