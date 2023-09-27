using System;

namespace Lab2Ex2
{
    //Ex.2 Scrieti o functie care va determina daca un numar este sau nu palindrom.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți un număr pentru a verifica palindromul: ");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int sum = Number(number);

            if (temp == sum)
            {
                Console.WriteLine($"Numarul {temp} este Palindrom.");
            }
            else
            {
                Console.WriteLine($"Numarul {temp} nu este Palindrom.");
            }

            static int Number(int num)
            {
                int remineder, sum = 0;

                while (num > 0)
                {

                    remineder = num % 10;


                    sum = (sum * 10) + remineder;


                    num /= 10;
                }

                return sum;
            }

        }


    }
}