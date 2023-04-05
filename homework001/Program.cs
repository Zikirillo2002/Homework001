using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
            // Task condition: Write a program to calculate the factorial of a given number.
            //                 Sample input: 5
            //                 Result: “Factorial of 5 is: 120.” 

        int number;
        long result = 1;
        bool isnumber;

        Console.Write("Enter the number : ");
            isnumber = int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine();

        while (!isnumber || number < 0)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number);
                            Console.WriteLine();
        }

        if (number == 0)
        {
            Console.WriteLine("The factorial of 0 is : 1");
        }

        else
        {
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }
            Console.WriteLine($"The factorial of {number} is : {result}");
        }

        Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
                Main(args); 
    }
}