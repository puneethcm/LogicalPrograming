using System;
namespace LogicalPrograming
{
	public class PrimeNumbers
	{
        public static void PrimeNumber()
        {
            int factor = 0;
            Console.WriteLine("\nEnter the numbers to find Prime");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    factor++;
                }
            }
            if (factor == 2)
            {
                Console.WriteLine("\n{0} is Prime Numbner", n);
            }
            else
            {
                Console.WriteLine("\n{0} is Not a Prime Number", n);
            }
        }
    }
}

