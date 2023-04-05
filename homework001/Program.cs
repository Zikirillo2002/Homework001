internal class Program
{
    private static void Main(string[] args)
    {
        /*  Task condition : Write a program which accepts a number from user and displays its factorial value. 
            *  Prepare  solution using: 
                                        • For 
                                        • While 
                                        • Do-while */

        int number, result = 1;
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
            Console.WriteLine("Result : 0! = 1 ");
        }

        else
        {
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }

            Console.WriteLine($" Result : {number}! = {result}");

        }

        Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
                Main(args);
    }
}