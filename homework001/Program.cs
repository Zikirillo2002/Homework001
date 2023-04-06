internal class Program
{
    private static void Main(string[] args)
    {
        //  Task condition : Write a program which accepts a number and determines whether the number is prime or not.
        //                   Input: 13                      
        //                   Output: “13 is a prime number.” 
        //                   Input: 4
        //                   Output: “4 is not a prime number.”

        int number, numberofdivisors = 0;
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

        if (number == 1 || number == 0)
            {
            Console.WriteLine($" The number {number} is neither prime nor complex !!! ");
            Console.WriteLine();
            Main(args);
        }

            else
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    numberofdivisors++;
                }
                if (numberofdivisors > 2)
                {
                    Console.WriteLine($" The number {number} is a complex number  ");
                    Console.WriteLine();
                    Main(args);
                }

            }
        }

        Console.WriteLine($" The number {number} is a prime number ");
        Console.WriteLine();
        Console.WriteLine();
        Main(args);
    }
}