internal class Program
{
    private static void Main(string[] args)
    {
        //  Task condition : Write a program which accepts a number and displays n terms of Fibonacci series
        //                   Fibonacci series: 0 1 2 3 5 8 13 21 … 
        //                   Input: 10
        //                   Output: 0 1 1 2 3 5 8 13 21 34

        int number;
        bool isnumber;

        Console.Write("Enter the number : ");
        isnumber = int.TryParse(Console.ReadLine(), out number);
        Console.WriteLine();

        while (!isnumber || number <= 0)
        {
            Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
            Console.WriteLine();
            Console.Write("Enter the number : ");
            isnumber = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine();
        }

        double[] fibonaciN = new double[number];

        if (number < 2)
        {
            fibonaciN[0] = 0;
        }

        else
        {
            fibonaciN[0] = 0;
            fibonaciN[1] = 1;
            for (int i = 2; i < number; i++)
            {
                fibonaciN[i] = fibonaciN[i - 1] + fibonaciN[i - 2];
            }
        }

        for (int j = 0; j < number; j++)
        {
            Console.WriteLine($" {j + 1}). {fibonaciN[j]} ");
        }

        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine();
        Main(args);
    }
}