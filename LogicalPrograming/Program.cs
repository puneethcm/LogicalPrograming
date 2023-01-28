using LogicalPrograming;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Programing Problems ");
        Console.WriteLine("\n1:Fibonacci numbers\n2:Prime Numbers\n3:Prefect Number\n4:Reverse Number\n5:Coupon Number");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Fibonacci.FindFibonacciNumber();
                break;

            case 2:
                PrimeNumbers.PrimeNumber();
                break;

            case 3:
                PrefectNumber.FindPrefectNumber();
                break;

            case 4:
                ReverseNumber.FindReverseNumber();
                break;

            case 5:
                CouponNumber.GetCouponNumber();
                break;
        }
        Console.ReadLine();
    }
}