using LogicalPrograming;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Programing Problems ");
        Console.WriteLine("\n1:Fibonacci numbers");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Fibonacci.FindFibonacciNumber();
                break;
        }
        Console.ReadLine();
    }
}