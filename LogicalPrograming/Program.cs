using LogicalPrograming;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Programing Problems ");
        Console.WriteLine("\n1:Fibonacci numbers\n2:Prime Numbers");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Fibonacci.FindFibonacciNumber();
                break;

            case 2:
                PrimeNumbers.PrimeNumber();
                break;
        }
        Console.ReadLine();
    }
}