internal class Program
{
    private static void Main(string[] args)
    {
        // Task condition : Write a program which accepts a number from user and prints all integers in range [1, 100] 
        //                  divisible by it.Prepare solution using: 
        //                  • For
        //                  • While

        int number, j = 0;
        bool isnumber;

        Console.Write("Enter  the number : ");
            isnumber = int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine();

        while (!isnumber || number <= 0)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number  !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number);
                            Console.WriteLine();
        }

        for (int i = 1; i <= 100; i++)
        {
            if (number % i == 0)
            {
                j++;
                Console.WriteLine($" {j}) --> {i}");
            }
        }

        Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
                Main(args);

    }
}