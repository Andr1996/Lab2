using System;

namespace Lab2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n = 2;

            for (int i = 2; i <= 8; i++ )
            {
                for (int j = 2; j <= i; j++ )
                {
                    if ((i % 10) % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
