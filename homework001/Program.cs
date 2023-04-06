internal class Program
{
    private static void Main(string[] args)
    {
        //  Task condition : Write a program which accepts two numbers and display all perfect 
        //                   numbers between their range.
        //                   Enter starting range: 1
        //                   Enter ending range: 50
        //                   Result: The Perfect numbers within 1 and 50 are: 6, 28.

        int number1, number2, divisibletotal = 0, u = 0;
        bool isnumber1, isnumber2;

        Console.Write("Enter starting range : ");
        isnumber1 = int.TryParse(Console.ReadLine(), out number1);

        while (!isnumber1 || number1 <= 0)
            {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
            Console.Write("Enter starting range : ");
            isnumber1 = int.TryParse(Console.ReadLine(), out number1);
        }

        Console.Write("Enter ending range : ");
        isnumber2 = int.TryParse(Console.ReadLine(), out number2);

        while (!isnumber2 || number2 < number1 || number2 <= 0)
            {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
            Console.Write("Enter ending range : ");
            isnumber2 = int.TryParse(Console.ReadLine(), out number2);
        }

        Console.Write("Perfect numbers : ");

        for (int i = number1; i <= number2; i++)
        {
            for (int j = 1; j <= (i / 2); j++)
            {
                if (i % j == 0)
                {
                    divisibletotal += j;
                }

            }
            if (i == divisibletotal)
            {
                Console.Write($"/ {i}");
                u++;
            }
            divisibletotal = 0;
        }

        if (u == 0)
        {
            Console.Write($"[ {number1}, {number2}] there is no perfect number in this range");
        }

        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine();
        Main(args);

    }
}