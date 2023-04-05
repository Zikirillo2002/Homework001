using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
      /*  Task condition : Write a program which reads integers until zero is entered and prints the length of the longest
                           sequence of consecutive numbers of the same value(and this value). 
                           Example:
                                      Input: 2 2 2 11 11 11 5 5 2 3 3 2 2 2 2 0
                                      Result: “Longest sequence: 4 times number 2.” 
                                      Input: 1 1 5 5 3 3 3 3 3 4 4 4 4 0
                                      Result: “Longest sequence: 5 times number 3.”   */

        int number, n = 1, maxnumbers = 1, numbers = 0, digitfirst = 0, maxdigit;
        bool isnumber;

        do
        {
            Console.Write("Enter  the number : ");
                isnumber = int.TryParse(Console.ReadLine(), out number);
                    Console.WriteLine();

            while (!isnumber || number < 0)
            {
                Console.WriteLine($"An error occurred in the system !!! \n Please enter another number  !!! ");
                    Console.WriteLine();
                        Console.Write("Enter the number : ");
                            isnumber = int.TryParse(Console.ReadLine(), out number);
                                Console.WriteLine();
            }

            if (digitfirst == number)
            {
                n++;
                if (maxnumbers < n)
                {
                    numbers = number;
                    maxnumbers = n;
                }
            }

            else
            {
                n = 1;
            }

            digitfirst = number;
        }
        while (number != 0);
        
        Console.WriteLine($"  Number {numbers} was repeated {maxnumbers} times");
            Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine();
                    Main(args);
    }
}