internal class Program
{
    private static void Main(string[] args)
    {
        //   Task condititon :  Write a program which display a multiplication table from 1x1 to 10x10:
        //                      1 1 2 3 4 … 
        //                      2 2 4 6 8 … 
        //                      3 3 6 9 12
        //                      4 4 8 16 20

        Console.WriteLine("                                               Multiplication table  ");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($" {i}.  Multiplication table [ {i} * {i} ]");
                Console.WriteLine();

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine();
        }

    }
}