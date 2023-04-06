internal class Program
{
    private static void Main(string[] args)
    {
        /*        Task condition :  Write a program which accepts a decimal number from user and displays it binary format. */

        int number, residual;
        string reversenumber, result;
        bool isnumber;

        Console.Write("Enter the number : ");
            isnumber = int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine();

        while (!isnumber)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number);
                            Console.WriteLine();
        }
        reversenumber = string.Empty;

        if (number == 0)
        {
            Console.WriteLine("Result : 0 ");
        }

        else
        {
            while (number > 0)
            {
                residual = number % 2;
                    reversenumber += Convert.ToString(residual);
                        number /= 2;
            }

            result = string.Empty;

            for (int i = reversenumber.Length - 1; i >= 0; i--)
            {
                result += reversenumber[i];
            }

            Console.WriteLine(result);

        }

        Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
                Main(args);
    }
}