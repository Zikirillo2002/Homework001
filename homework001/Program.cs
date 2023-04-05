internal class Program
{
    private static void Main(string[] args)
    {
        // Task condition :  Write a program which reads four numbers from a user and prints difference between
        //                   the largest and the smallest of them. 

        int number1, number2, number3, number4, result;
        bool isnumber;

        Console.Write("Enter the number1 : ");
            isnumber = int.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine();

        while (!isnumber)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number1 : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number1);
                            Console.WriteLine();
        }

        Console.Write("Enter the number2 : ");
            isnumber = int.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine();

        while (!isnumber)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number2 : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number2);
                            Console.WriteLine();
        }

        Console.Write("Enter the number3 : ");
            isnumber = int.TryParse(Console.ReadLine(), out number3);
                Console.WriteLine();

        while (!isnumber)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number3 : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number3);
                            Console.WriteLine();

        }
        Console.Write("Enter the number4 : ");
            isnumber = int.TryParse(Console.ReadLine(), out number4);
                Console.WriteLine();

        while (!isnumber)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                    Console.Write("Enter the number4 : ");
                        isnumber = int.TryParse(Console.ReadLine(), out number4);
                            Console.WriteLine();
        }

        int maxnumber = Math.Max(Math.Max(Math.Max(number1, number2), number3), number4);
        int minnumber = Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);

        Console.WriteLine($" Natija --> difference = Maxnumber - Minnumber = {maxnumber} - {minnumber} = {maxnumber - minnumber}");
            Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine();
                    Main(args);
    }
}